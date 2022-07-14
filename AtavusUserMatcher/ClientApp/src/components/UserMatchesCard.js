import React from "react";

const UserMatchesCard = ({ failedUser, matches, onResolved, className }) => {
  return (
    <div className={"shadow-lg rounded bg-white w-full flex flex-column p-4" + " " + className}>
      <div className="">
        <p className="text-lg font-semibold">{failedUser.firstName} {failedUser.lastName}</p>
        <p>{failedUser.email}</p>
        <p>Failed Reason: {failedUser.failReason}</p>
      </div>
      <h1 className="mt-4 font-semibold">Matches Found:</h1>
      <div className="mt-2 overflow-x-auto">
        <table className="table table-zebra w-full">
          <thead>
            <tr>
              <th>Email</th>
              <th>First Name</th>
              <th>Last Name</th>
              <th>Match %</th>
            </tr>
          </thead>
          <tbody>
            {matches.slice(0,3).map(x =>
              <tr key={x.email}>
                <td>{x.email}</td>
                <td>{x.firstName}</td>
                <td>{x.lastName}</td>
                <td>{x.score}%</td>
              </tr>
            )}
          </tbody>
        </table>
      </div>
      <button onClick={onResolved} className="btn bg-green-500">Mark as resolved</button>
    </div>
  )
};

export default UserMatchesCard;

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