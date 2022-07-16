const LS_TOKEN_KEY = "LS_TOKEN";

const AuthService = {
    getAuthToken: () => {
        return localStorage.getItem(LS_TOKEN_KEY);
    },

    setAuthToken: (token) => {
        localStorage.setItem(LS_TOKEN_KEY, token);
    },

    logout: () => {
        localStorage.removeItem(LS_TOKEN_KEY);
    }
}

export default AuthService;