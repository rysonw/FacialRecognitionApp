# Facial Recognition App for Windows (WinForms)

### Installation:

1. Go to Solution Explorer in Visual Studio
2. Click on "Restore NuGet Packages"
3. Build as x64 Platform
4. Install Emgu.CV
5. Run the application

### Overview and Purpose:

This app is a basic facial detection app. Using the Emgu.CV module, we are able to use AI and build our own model to recognize faces present in the picture. We can also take images and generate real-time mood detection through the Google Cloud Vision API.
<br>

### Detecting Faces:

Startup:
![Startup](https://user-images.githubusercontent.com/91065673/200977683-2d3ea92f-94a4-4dd6-956a-d8ce816137ec.png)
<br>

Clicking on "Detect Faces", we enable the smaller facial detection screen on the right.

![DetectFaces Sample](https://user-images.githubusercontent.com/91065673/200977629-504b4282-1cb1-4026-beec-a2d33733822e.gif)

### Saving Images:

We save images in folders locally within the project. If the folders are not found, we create the folder and store the images to be saved inside of it.

```
if (!Directory.Exists(pathTrain)) //We create this directory if it does not exist
{
  Directory.CreateDirectory(pathTrain);
}
```

### Mood Detection:

After the image is saved to the directory, the image is then sent to the Google Vision API for classification. We display the information from the JSON response in text boxes and through a circle graph. Before each image is saved, the folder used to store the images to be sent is cleared. Below are some examples of what is being detected:

Joy:
<br>
![Joy](https://user-images.githubusercontent.com/91065673/200970747-99545b40-2149-4439-b518-5fdb9fc6953d.png)
<br>

Anger:
<br>
![Anger (2)](https://user-images.githubusercontent.com/91065673/202619167-28007174-b3c3-4e34-9723-2dac5d043949.png)
<br>

Neutral:
<br>
![Neutral (2)](https://user-images.githubusercontent.com/91065673/202619165-71466cc6-0fe8-45b6-9a79-1e7dab8d94fe.png)
<br>
