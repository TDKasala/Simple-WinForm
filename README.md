# Simple-WinForm

# README

## Overview
This is a simple Windows Forms application developed in C# to collect and display user information. The application provides fields for users to input their name, surname, gender, date of birth, race, and hobbies. It also includes validation to ensure that all required fields are filled before submission.

## Getting Started
To use this application, you can follow these steps:

1. Clone or download the repository to your local machine.
2. Open the solution in Visual Studio or any C# IDE.
3. Build the solution to ensure all dependencies are resolved.
4. Run the application.

## Usage
Once the application is running, users can input their information into the respective fields:

- **Name**: Enter your first name.
- **Surname**: Enter your last name.
- **Gender**: Select your gender from the dropdown menu.
- **Date of Birth**: Choose your date of birth using the date picker.
- **Race**: Select your race by clicking the appropriate radio button.
- **Hobbies**: Check any hobbies that apply to you.

### Buttons
- **Submit**: Click this button to display a message box showing the entered information.
- **Clear**: Click this button to clear all fields.
- **Validate**: Click this button to check if all required fields are filled. If any required fields are empty, an error message will be displayed. Otherwise, a success message will be shown.

## Code Structure
The `Form1` class contains event handlers for various actions performed by the user. These handlers include:
- `btnSubmit_Click`: Collects user input and displays it in a message box.
- `btnClear_Click`: Clears all input fields.
- `btnValidate_Click`: Validates input fields and displays appropriate messages.
- Event handlers for text box and check box changes.

## Contributors
This code was written by Denis Kasala.

