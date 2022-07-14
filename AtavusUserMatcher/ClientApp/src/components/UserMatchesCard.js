import React from "react";

const UserMatchesCard = ({failedUser, matches}) => {



  return (
    <div>
      
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