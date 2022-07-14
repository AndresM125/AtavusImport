import React, { useRef, useState } from "react";

const Index = () => {

  const [selectedFile, setSelectedFile] = useState(null);
  const [selectedFileName, setSelectedFileName] = useState("No file selected");
  const [data, setData] = useState("");
  const inputFile = useRef();

  const onSelectFileClicked = () => {
    inputFile.current.click();
  }

  const inputFileChangedHandler = (event) => {
    setSelectedFile(event.target.files[0]);
    setSelectedFileName(event.target.files[0].name);
  };

  const onSubmitCSVFile = () => {
    var reader = new FileReader();
    reader.onload = function () {
      console.log(reader.result);
      var jsonData = csvToJson(reader.result, ["email", "member_code", "first_name", "last_name", "organization", "plan_metadata", "fail_reason"]);
      setData(jsonData);
      setSelectedFile(null);

      fetch('/findUsers', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: jsonData
      })
      .then(response => response.json())
      .then(result => {
        console.log(result);
      })
      .catch(error => {
        // TODO: Error handling
        console.error('Error:', error);
      });
    };
    reader.readAsBinaryString(selectedFile);
  };

  const csvToJson = (text, headers, quoteChar = '"', delimiter = ',') => {
    const regex = new RegExp(`\\s*(${quoteChar})?(.*?)\\1\\s*(?:${delimiter}|$)`, 'gs');

    const match = line => [...line.matchAll(regex)]
      .map(m => m[2])  // we only want the second capture group
      .slice(0, -1);   // cut off blank match at the end

    const lines = text.split('\n');
    const heads = headers ?? match(lines.shift());

    return lines.map(line => {
      return match(line).reduce((acc, cur, i) => {
        // Attempt to parse as a number; replace blank matches with `null`
        const val = cur.length <= 0 ? null : Number(cur) || cur;
        const key = heads[i] ?? `extra_${i}`;
        return { ...acc, [key]: val };
      }, {});
    });
  }

  return (
    <div className="min-w-screen min-h-screen p-8">
      <div className="flex flex-col justify-center items-center p-4 bg-gray-200 rounded">
        <p>Upload a CSV file to get started</p>
        <p>File Selected: {selectedFileName}</p>
        <input ref={inputFile} className="hidden" type="file" name="file" onChange={inputFileChangedHandler} accept=".csv" />
        <button className="btn" onClick={onSelectFileClicked}>Select File</button>
        {selectedFile != null && <button className="btn" onClick={onSubmitCSVFile}>Submit</button>}
      </div>

      <p>{JSON.stringify(data)}</p>
    </div>
  )
};

export default Index;

/*
/findUsers
{
  "results": [
      {
          "failedImportUser": {
              "email": "quentinsbusiness@gmail.com",
              "firstName": "Quentin",
              "lastName": "White ",
              "organization": "",
              "failReason": "sf"
          },
          "matches": [
              {
                  "email": "quentinsbusiness@gmail.com",
                  "firstName": "Quentin",
                  "lastName": "White",
                  "score": 99
              },
              {
                  "email": "quentin.uta@gmail.com",
                  "firstName": "Quentin",
                  "lastName": "Butler",
                  "score": 74
              },
              {
                  "email": "quentinesterling@gmail.com",
                  "firstName": "Quentin",
                  "lastName": "Sterling",
                  "score": 72
              },
              {
                  "email": "dustinwhite1259@gmail.com",
                  "firstName": "Dustin",
                  "lastName": "White",
                  "score": 67
              },
              {
                  "email": "tsuposey@gmail.com",
                  "firstName": "Quentin",
                  "lastName": "Posey",
                  "score": 67
              }
          ]
      },
      {
          "failedImportUser": {
              "email": "tjsbball58@aol.com",
              "firstName": "Thurmond Stone",
              "lastName": "",
              "organization": "",
              "failReason": ""
          },
          "matches": [
              {
                  "email": "tjsbball58@aol.com",
                  "firstName": "Thurmond",
                  "lastName": "Stone",
                  "score": 98
              },
              {
                  "email": null,
                  "firstName": "Thurmond",
                  "lastName": "Stone",
                  "score": 58
              },
              {
                  "email": "jstone@nederlandisd.org",
                  "firstName": "Thurmond",
                  "lastName": "Stone",
                  "score": 56
              },
              {
                  "email": "txhsbb15@gmail.com",
                  "firstName": "Tom ",
                  "lastName": "Collins",
                  "score": 56
              },
              {
                  "email": "teaton68@aol.com",
                  "firstName": "Terrence",
                  "lastName": "Eaton",
                  "score": 56
              }
          ]
      }
  ]
}

*/