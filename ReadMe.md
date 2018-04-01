#Asarae

## Description
A simple project to test solution structure and compliation for multi-level enterprise applications using MvvM and having different UI applications.

It will use both caliburn.micro as the MvvM framework and Csla for the Business Object layer.

## Project Naming Conventions
The solutions in the project will be named as follows

  * **Asarae.DAI**	Data Access Interfaces
  * **Asarae.DAL.*Plattform*** - Data Access Layer for a specific plattform
    * **Asarae.DAL.Mock** - Data Access Layer for tests and design uses
    * **Asarae.DAL.SqlServer** - Data Access Layer for Microsoft SqlServer databases
	* **Asarae.DAL.MySQL** - Data Access Layer for MySQL
  * **Asarae.Library.BO[*.Specification*]**	Business Objects - The Csla Business objects in the solution. Should several levels be necessary, the specification is added to the end. 
  * **Asarae.Library.VM[*.Specification*]** - The viewmodels for the application. Should several levels be necessary, the specification is added to the end.
  * **Asarae.UI*.Platform*[*.Specification*]** - The UI for a given plattform, should the UI be split into library files, they are defined using the specification
    * **Asarae.UI.UWP** - UI for Universal Windows Plattform apps
    * **Asarae.DAL.WPF** - UI for WPF applications.
  * **Asarae.Library.Utility[*.Specification*]**	Application wide utility solutions

  Usually VM and UI libraries usually come in pairs. Utilities for specific layers (DAL or UI) would be in DAL.Utility[.xxx] solutions.

 