import React from 'react';
import { Navigate } from 'react-router-dom';
import AuthService from '../services/authService';

const AuthenticatedView = ({ children }) => {

    const isLoggedIn = AuthService.getAuthToken() != null;

    if (!isLoggedIn) {
        return (<Navigate to={{ pathname: '/login' }} />);
    }
    else {
        return (<>{children}</>);
    }
};

export default AuthenticatedView;