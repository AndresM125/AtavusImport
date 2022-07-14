import React, { useRef, useState } from "react";
import UserMatchesCard from "../components/UserMatchesCard";
import useLocalStorage from "../hooks/useLocalStorage";

const Index = () => {
  const [selectedFile, setSelectedFile] = useState(null);
  const [selectedFileName, setSelectedFileName] = useState("No file selected");
  const [isLoading, setIsLoading] = useState(false);
  const [hasErrorsFromServer, setHasErrorsFromServer] = useState(false);
  const [resultMatches, setResultMatches] = useLocalStorage("RESULT_MATCHES_KEY", []);
  const [resolvedEmails, setResolvedEmails] = useLocalStorage("RESOLVED_EMAILS", {});

  const inputFile = useRef();

  const onSelectFileClicked = () => {
    inputFile.current.click();
  }

  const inputFileChangedHandler = (event) => {
    setSelectedFile(event.target.files[0]);
    setSelectedFileName(event.target.files[0].name);
  };

  const onSubmitCSVFile = () => {
    setIsLoading(true);
    setHasErrorsFromServer(false);
    var reader = new FileReader();
    reader.onload = function () {
      var jsonData = csvToJson(reader.result, ["email", "member_code", "first_name", "last_name", "organization", "plan_metadata", "fail_reason"]);
      var sanitizedData = sanitizeData(jsonData);
      setSelectedFile(null);

      fetch('/findUsers', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({ failedImportUsers: sanitizedData })
      })
        .then(response => response.json())
        .then(result => {
          console.log(result);
          setResultMatches(result.results);
          setIsLoading(false);
        })
        .catch(error => {
          // TODO: Error handling
          console.error('Error:', error);
          setIsLoading(false);
          setHasErrorsFromServer(true);
        });
    };
    reader.readAsBinaryString(selectedFile);
  };

  const sanitizeData = (data) => {
    var duplicates = {};
    var res = []
    for (let i = 0; i < data.length; i++) {
      if (data[i].email != null && data[i].email != "email") {
        var key = data[i].email + data[i].first_name + data[i].last_name;
        if (!(key in duplicates) && !(key in resolvedEmails)) {
          res.push({
            email: data[i].email,
            firstName: data[i].first_name,
            lastName: data[i].last_name,
            organization: data[i].organization,
            failReason: data[i].fail_reason
          });
          duplicates[key] = true;
        }
      }
    }
    duplicates = {};
    return res;
  }

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

  const onResolveMatch = (failedImportUser) => {
    var userKey = failedImportUser.email + failedImportUser.firstName + failedImportUser.lastName;

    setResolvedEmails({ ...resolvedEmails, [userKey]: true });
    setResultMatches(resultMatches.filter(x => x.failedImportUser.email !== failedImportUser.email || x.failedImportUser.firstName !== failedImportUser.firstName || x.failedImportUser.lastName !== failedImportUser.lastName));
  };

  const onResetAllData = () => {
    setResolvedEmails({});
    setResultMatches([]);
  };

  if (isLoading) {
    return (
      <div className="min-w-screen min-h-screen flex flex-col items-center justify-center">
        <h1 className="text-lg font-semibold">Matching Users Against Database Please Wait...</h1>
        <progress className="progress w-56 mt-4"></progress>
      </div>
    )
  }

  return (
    <div className="min-w-screen min-h-screen p-8">
      <div className="flex flex-col justify-center items-center p-4 shadow-lg rounded bg-white">
        {hasErrorsFromServer && <p className="text-red-500">*An unexpected error has occured please try again.</p>}
        <p>Upload a CSV file to get started</p>
        <p className="mt-2">File Selected: {selectedFileName}</p>
        <input ref={inputFile} className="hidden" type="file" name="file" onChange={inputFileChangedHandler} accept=".csv" />
        <button className="btn mt-2 w-[300px]" onClick={onSelectFileClicked}>Select File</button>
        {selectedFile != null && <button className="btn mt-2 w-[300px] bg-green-500" onClick={onSubmitCSVFile}>Submit</button>}
      </div>

      <div className="mt-8 flex flex-col justify-center items-center p-4 shadow-lg rounded bg-white">
        <p>*Only use the reset all data button when you need a clean slate</p>
        <button onClick={onResetAllData} className="btn mt-4 bg-red-500">RESET ALL DATA</button>
      </div>

      {
        resultMatches.map((x, idx) =>
          <UserMatchesCard
            key={x.failedImportUser.email + x.failedImportUser.firstName + x.failedImportUser.lastName}
            className={"mt-8"}
            failedUser={x.failedImportUser}
            matches={x.matches}
            onResolved={_ => { onResolveMatch(x.failedImportUser) }}
          />
        )
      }
    </div>
  )
};

export default Index;