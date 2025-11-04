/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./personalsite/**/*.{razor,html,cshtml}",
    "./personalsite/wwwroot/index.html"
  ],
  theme: {
    extend: {
      colors: {
        dark: {
          DEFAULT: '#0B0B0D',
          lighter: '#111111',
          border: '#1F1F23',
        }
      },
      fontFamily: {
        sans: ['Inter', 'system-ui', '-apple-system', 'sans-serif'],
      },
    },
  },
  plugins: [],
}

