# Quick Start Guide

## 🚀 Running Your Site

```bash
cd personalsite
dotnet run
```

Then open your browser to the URL shown (typically `https://localhost:5001`)

## 🎨 Customizing Your Site

### 1. Update Your Personal Information

**Navigation & Footer** (`personalsite/Shared/Navigation.razor` and `personalsite/Layout/MainLayout.razor`):
- Replace "YourName" with your actual name
- Update social media links (GitHub, LinkedIn, Twitter)

**Contact Page** (`personalsite/Pages/Contact.razor`):
- Update email address: `your.email@example.com`
- Update social media links

### 2. Customize the Home Page

**Hero Section** (`personalsite/Pages/Home.razor`):
- Change the headline text
- Update the subtext to describe yourself
- Modify the feature cards to highlight your skills

### 3. Add Your Projects

**Projects Page** (`personalsite/Pages/Projects.razor`):
- Replace placeholder projects with your actual projects
- Add project names, descriptions, tech stacks
- Update GitHub and live demo links

### 4. Update Your About Page

**About Page** (`personalsite/Pages/About.razor`):
- Write your bio and background
- Update technical skills
- Add your experience and education

## 🎯 Key Files to Customize

| File | What to Change |
|------|----------------|
| `Shared/Navigation.razor` | Your name and navigation links |
| `Pages/Home.razor` | Hero headline, description, feature cards |
| `Pages/Projects.razor` | Your projects, links, and tech stacks |
| `Pages/About.razor` | Bio, skills, and experience |
| `Pages/Contact.razor` | Email and social media links |
| `Layout/MainLayout.razor` | Footer social links and copyright |

## 🌈 Changing Colors

If you want to change the color scheme, edit `personalsite/wwwroot/css/app.css`:

**Current Colors:**
- Background: `#0B0B0D` (dark black)
- Cards: `#111111` (slightly lighter)
- Borders: `#1F1F23` (subtle gray)
- Primary (buttons/links): `#6366f1` (indigo)

**To Change:**
1. Find all instances of the color hex code in `app.css`
2. Replace with your preferred color
3. Keep contrast in mind for readability

## 📱 Testing Responsive Design

The site is responsive by default. Test it by:
1. Resizing your browser window
2. Opening Chrome DevTools (F12)
3. Using the device toolbar (Ctrl+Shift+M)
4. Testing on actual mobile devices

## 🔧 Tailwind CSS (Advanced)

If you want to modify Tailwind styles:

1. Install Node.js from https://nodejs.org
2. Run `npm install` in the project root
3. Edit `personalsite/wwwroot/css/site.css`
4. Run `npm run build:css` to compile
5. Your changes will appear in `app.css`

**Note:** The pre-compiled `app.css` works perfectly without Node.js!

## 🆘 Common Issues

**Issue: Styles not loading**
- Make sure `app.css` exists in `personalsite/wwwroot/css/`
- Check that `index.html` has the correct CSS link

**Issue: Navigation not showing**
- Verify `_Imports.razor` includes `@using personalsite.Shared`
- Check that `MainLayout.razor` has the `<Navigation />` component

**Issue: Pages not routing**
- Ensure each page has `@page "/route"` at the top
- Check that the route matches the link in Navigation

## 🎉 Next Steps

1. Replace all "YourName" placeholders with your real name
2. Add your actual projects and experience
3. Update contact information and social links
4. Add your own images (if desired)
5. Deploy to Azure, Netlify, or GitHub Pages

## 📝 Pro Tips

- **Keep it simple**: Less is more in modern design
- **Use real content**: Replace all placeholders with actual information
- **Test on mobile**: Most visitors will view on mobile devices
- **Optimize images**: If you add images, compress them first
- **Update regularly**: Keep your projects and experience current

---

**Need help?** Check the full `README.md` for more details!

