import React, { useState } from "react"
import { useNavigate } from "react-router-dom";
import AuthService from "../services/authService";

const AdminLogin = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const navigate = useNavigate();

  const onSubmit = (event) => {
    event.preventDefault();
    console.log(username);
    console.log(password);

    fetch('/api/auth/login', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({ username, password })
    })
    .then(response => response.json())
    .then(result => {
      console.log(result);
      AuthService.setAuthToken(result.token);
      navigate("/admin");
    })
    .catch(error => {
      // TODO: Error handling
      console.error('Error:', error);
    });
  };

  return (
    <div className="p-4 w-screen h-screen flex flex-col items-center justify-center">
      <h1 className="text-3xl font-semibold">
        Atavus Internal Matching Tool
      </h1>
      <form className="mt-4" onSubmit={onSubmit}>
        <div className="flex flex-col w-[450px] bg-gray-200 rounded px-8 py-16">
          <label>
            <p>Username:</p>
            <input className="input w-full mt-1" type="text" name="username" value={username} onChange={e => setUsername(e.target.value)} />
          </label>

          <label className="mt-4">
            <p>Password:</p>
            <input className="input w-full mt-1" type="password" name="password" value={password} onChange={e => setPassword(e.target.value)} />
          </label>

          <input className="btn mt-4" type="submit" value="Submit" />
        </div>
      </form>
    </div>
  );
}

export default AdminLogin