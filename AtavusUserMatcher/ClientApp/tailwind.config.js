module.exports = {
    content: [
        "./src/**/*.{js,jsx,ts,tsx}",
    ],
    theme: {
        extend: {},
    },
    plugins: [require("daisyui")],

    daisyui: {
        styled: true,
        base: true,
        utils: true,

        themes: [
            {
                mytheme: {
                    "primary": "#1e3a8a",
                    "secondary": "#D926A9",
                    "accent": "#1FB2A6",
                    "neutral": "#191D24",
                    "base-100": "#2A303C",
                    "info": "#3ABFF8",
                    "success": "#36D399",
                    "warning": "#FBBD23",
                    "error": "#F87272",
                },
            },
        ],
        darkTheme: "mytheme"
    },
}