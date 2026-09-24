# C# Windows Forms: Gym Fee Calculator

This repository contains the completed source code for Tutorial #5 on my YouTube channel. It demonstrates how to process multi-variable numeric inputs, apply VAT and fee calculation logic, and display formatted currency outputs using C# and Windows Forms.

**📺 Watch the full tutorial here:** (https://www.youtube.com/@CodedByVin).

## Features
* Calculates the total cost excluding VAT, the 15% VAT amount, and the final total including VAT based on user inputs.
* Utilizes numeric up/down controls for entering the monthly base fee, training session rate, and number of sessions.
* Presents the breakdown of calculated costs clearly formatted as currency (Rands) in a rich text box.
* Features a custom graphical close button (an "X" icon) in the top corner that exits the application.

## Mathematical Formulas:
* Total ex. VAT = Monthly Base Fee + (Training Session Rate × Number of Sessions).
* VAT (15%) = Total ex. VAT × 0.15.
* Total inc. VAT = Total ex. VAT + VAT

## Tech Stack
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **IDE:** Visual Studio

## How to Run This Code
1. Click the green **Code** button and download the ZIP file, or clone the repository.
2. Extract the folder and open the `.sln` (Solution) file using Visual Studio.
3. Ensure you have the **.NET desktop development** workload installed.
4. Press **Start** (or `F5`) in Visual Studio to run the application.

## Screenshots
<img width="629" height="510" alt="image" src="https://github.com/user-attachments/assets/4991b5e5-5d51-4824-bbba-aad477512468" />
<img width="632" height="511" alt="image" src="https://github.com/user-attachments/assets/19dc3d0e-d735-434e-b8f9-ccbdc0033f7d" />

