# DoctorPortal
#### CIS 299WK Project by the Vindicator's team

# What is this application for?
#### DoctorPortal: A gui application written in VB.net that allows patients to:
* Set/Cancel appointments
* Receive a prescription refill from their doctors
* Communicate with their healthcare providers
* Pay for their medical bills
* View their medical information
* Provide vital information to healthcare providers

# Notes
This application is a front end prototype. Nothing happens in the back end yet. It doesn't communicate with the database yet and some parts of the application is subject to a major overhaul.

# Running the application
Head over to release, you can download the executable.
Windows will warn you about this application and you can do two things:
* If you trust us, click 'more info' and a 'run anyway' button will appear
* If you don't trust us, just close the warning. We won't take it personally.


# Screenshots
### Splash screen :)
![Image](https://i.ibb.co/sqLRxGn/splash-Screen.jpg)

### Client info
![Image](https://i.ibb.co/Wcz3Mg7/client-Info.jpg)

# TODO
- [ ] Overhaul main menu layout (Working on it)
- [ ] Change all form's FormBorderStyle to FixedSingle because this application isn't responsize to resizes, yet
- [ ] Add log in verification
- [ ] Fix an issue where closing a form that has a parent form hidden doesn't kill the program entirely. This can be done by setting the buttons that spawn the child forms to use me.close() instead of me.hide()
- [x] Change the ListBox object to a more uniform alternative in MedicationRefilling form
- [ ] Change the MedHx text boxes to read only. Actually, Any text box that doesn't require user intervention to be read only.
