# MusicPlayer

A super-simple C# desktop music player built with .NET 10 and Windows Forms.

<img width="424" height="427" alt="image" src="https://github.com/user-attachments/assets/61ba21a2-0c07-4689-8cd9-e8cbc5e714d1" />

*Figure 1 - MusicPlayer in action.*

This app is a bare-bones example of how to build an audio player with .Net.
The hard-lifting is all accomplished by the built-in .Net library MediaPlayer. This library lives in the System.Windows.Media namespace, so
it's part of Windows Presentation Framework (WPF), and not of Windows Forms. For this reason, to include it in a Windows Forms project,
we need to enable WPF in the .csproj file, as shown in the next figure.

<img width="419" height="242" alt="image" src="https://github.com/user-attachments/assets/d2d0ff88-6d01-4e04-bdf9-072b65759d36" />

*Figure 2 - Enabling WPF in the project settings for MediaPlayer support.*

The screen is laid out with a series of docked panels, as shown in the next figure.

<img width="427" height="457" alt="image" src="https://github.com/user-attachments/assets/d4379358-a561-45bf-9265-4b079dc26e15" />

*Figure 3 - How docked panels are used to layout the screen.*

By using docked panels, the UI elements resize predictably when the main form is resized. No need to fiddle with weird Anchoring properties on all the elements.
The panels handle all the resizing themselves.

When laying out docked panels, their order (back to front) is important. The first panel added in the Visual Designer is the backmost.
Additional panels appear on top of panels already added. With top-docked panels, the first one goes to the top, the second one docks right under it.
Conversely, for bottom-docked panels the first one goes to the bottom, the second one docks right over it, and so on.
The panel with Dock=Fill, which contains the list of songs, needs to be the front-most panel. You either must add it last, or you can use the
"Bring to Front" button in the Visual Designer, as shown in the figure below.

<img width="765" height="374" alt="image" src="https://github.com/user-attachments/assets/f04857d4-6121-46b8-ad80-08007eb931f4" />

*Figure 4 - The Bring-to-Front button in the Visual Designer.*

One last note regarding the symbols on the play buttons. Once upon a time we would have needed to import them as bitmaps into the project and add them as embedded resources.
All that complication is avoided by using the symbols as font characters. Several fonts include media player symbols. You can lookup symbols on the web or simply use the
Character Map app, which is built into Windows itself. Below are the symbols we need, with their Unicode values.

⏸  U+23F8

▶  U+25B6

⏮  U+23EE

⏹  U+23F9

⏭  U+23ED

The figure below shows the use of Windows Character Map to do the looking up.

<img width="476" height="507" alt="image" src="https://github.com/user-attachments/assets/d35f5668-799e-48c6-a173-f4609ee4e7b8" />

*Figure 5 - Using the Windows Character Map to find symbols used in MusicPlayer.*



