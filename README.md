# ImageCropDemo

# ImageCropDemo – Image Upload with Crop Tool

This project demonstrates **client-side image cropping** using CropperJS and saving the cropped image to the server and database.

---

## 🚀 Features
- Select image from device
- Crop image in browser
- Save cropped image to server
- Save image path in SQL Server

---

## 🧱 Tech Stack
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- CropperJS v1.5.13

---

## 📁 Key Files
Models/CroppedImage.cs
Models/ImageCropRequest.cs
Controllers/ImageController.cs
Views/Image/Upload.cshtml
Views/Image/List.cshtml
wwwroot/uploads/



---

## ⚠️ IMPORTANT
Use **CropperJS v1.5.13 only**  
Newer versions break classic initialization.

---

## ⚙️ Setup Steps

### 1️⃣ Create Upload Folder
wwwroot/uploads

### 2️⃣ Run Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
▶️ Run Project

dotnet run
Open:
```
/Image/Upload
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/5ca6a5be-2b26-4882-a654-9a07e2bb082f" />

/Image/List
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/7f19834d-7fd5-465e-b4dd-7bcd44385ce9" />


🧪 Common Fixes
-Do not hide <img> using display:none
-Ensure IgnoreAntiforgeryToken is applied
-Check Network tab for POST request


