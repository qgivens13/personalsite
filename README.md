# Personal Site - Blazor WebAssembly with Tailwind CSS

A modern, minimal personal website built with Blazor WebAssembly and styled with Tailwind CSS, inspired by Linear.app's design language.

## Features

- ✨ Modern, dark-themed UI inspired by Linear.app
- 🎨 Tailwind CSS for utility-first styling
- 📱 Fully responsive design
- 🚀 Fast, client-side rendering with Blazor WebAssembly
- 🎯 Clean, minimal aesthetic with Inter font
- 🧩 Modular component architecture

## Project Structure

```
personalsite/
├── Layout/
│   └── MainLayout.razor       # Main layout with navigation and footer
├── Pages/
│   ├── Home.razor            # Home page with hero section
│   ├── Projects.razor        # Projects showcase page
│   ├── About.razor           # About page
│   └── Contact.razor         # Contact page with form
├── Shared/
│   └── Navigation.razor      # Navigation component with mobile menu
└── wwwroot/
    ├── css/
    │   ├── app.css          # Compiled Tailwind CSS (ready to use)
    │   └── site.css         # Source CSS with Tailwind directives
    └── index.html           # Main HTML file with Inter font
```

## Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- Node.js and npm (optional, for Tailwind CSS compilation)

### Running the Project

1. Navigate to the project directory:
```bash
cd personalsite
```

2. Run the Blazor application:
```bash
dotnet run
```

3. Open your browser and navigate to `https://localhost:5001` (or the URL shown in the terminal)

## Tailwind CSS Setup (Optional)

The project includes a pre-compiled `app.css` file, so Node.js is not required to run the application. However, if you want to modify Tailwind styles and recompile:

### Install Node.js and Dependencies

1. Install Node.js from https://nodejs.org/

2. Install npm dependencies:
```bash
npm install
```

3. Build Tailwind CSS (one-time):
```bash
npm run build:css
```

4. Or watch for changes during development:
```bash
npm run watch:css
```

## Customization

### Changing Colors

Edit the `tailwind.config.js` file to customize the color scheme:

```javascript
colors: {
  dark: {
    DEFAULT: '#0B0B0D',  // Main background
    lighter: '#111111',   // Card backgrounds
    border: '#1F1F23',    // Border color
  }
}
```

### Updating Content

1. **Name/Logo**: Update "YourName" in `Navigation.razor` and throughout the pages
2. **Contact Info**: Update email and social links in `Contact.razor` and `MainLayout.razor`
3. **Projects**: Edit the project cards in `Projects.razor`
4. **About**: Update your bio and experience in `About.razor`
5. **Home**: Customize the hero section and feature cards in `Home.razor`

### Adding New Pages

1. Create a new `.razor` file in the `Pages/` directory
2. Add the `@page "/your-route"` directive at the top
3. Add a link to the page in `Navigation.razor`

## Design System

### Colors
- Background: `#0B0B0D` (dark)
- Card/Surface: `#111111` (dark-lighter)
- Border: `#1F1F23` (dark-border)
- Primary: Indigo (`#6366f1`, `#4f46e5`)
- Text: Gray scale from `#f3f4f6` to `#9ca3af`

### Typography
- Font: Inter (imported from Google Fonts)
- Headlines: Bold to Extrabold (600-800)
- Tight letter spacing for headlines (`tracking-tight`, `tracking-tighter`)

### Spacing
- Consistent use of Tailwind's spacing scale
- Large padding on sections (py-20, py-32)
- Generous gaps between elements

## Browser Support

- Chrome/Edge (latest)
- Firefox (latest)
- Safari (latest)

## License

This project is open source and available under the MIT License.

## Acknowledgments

- Design inspired by [Linear.app](https://linear.app)
- Built with [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- Styled with [Tailwind CSS](https://tailwindcss.com)
- Typography using [Inter font](https://rsms.me/inter/)

