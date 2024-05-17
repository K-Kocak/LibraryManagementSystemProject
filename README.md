# Library Management System

A Library Management System for managing a database of books with its authors and genres, and allowing these books to be issued to members.

## Contents

- [Features](#features)
- [Installation](#installation)
- [Functionality and Screenshots](#functionality-and-screenshots)
- [Credits](#credits)

## Features

- Login screen for users separated by two users types, admins and users. There is also one owner account.
- Latest books added to the system.
- Total books, authors, and genres in each respective database.
- Manage books section for adding, editing, removing books with an option to see the entire book database.
- Manage authors section for adding, editing and removing authors. Option to see all books by an author also available.
- Manage genres for all books with adding, editing and deleting genres.
- Manage members that are part of the library.
- Issue books to members and have them return the book by a set date, with the option to set books as lost.
- Manage users that can use this library system. Only the owner user type can access this.

## Installation

### Prequisites

- [XAMPP Web Server](https://www.apachefriends.org/)
- [MySQL Connector for .NET](https://dev.mysql.com/downloads/connector/net/)  (Project uses MySQL Connector NET 8.0.33, latest ver is 8.4.0)
- Clone the repo with `git clone https://github.com/K-Kocak/LibraryManagementSystemProject.git`

## Functionality and Screenshots

*Login screen*

![Login screen](./docs/readme/LoginFormPicture.png)

User login screen. By default (for development purposes) the fields entered in are for the owner account.
- Checks username and password entered and compares to user database. If match is found, user logs in.

*Dashboard*

![Dashboard](./docs/readme/DashboardFormPicture.png)

Main hub for this project.
- User has several options to pick on the left hand panel to access Books, Authors, Genres, Members, Books Issued (Circulation) and Users.
- Only the owner account can access Users.
- Admins can access everything except Users.
- Regular users can only access books, authors and genres.
- Information about the four latest books is displayed (the front cover and the price of the book).
- Total number of books, authors and members in their respective databases is shown.

*Manage Books - Add Book*

![Manage books add book](./docs/readme/ManageBooksAddBookPictureEntries.png)

User enters information about a book they want added to the database. Code sorts out ID for the book automatically.
- The information a user can enter is seen in the picture, but includes ISBN, title of the book, the author of the book, the genre, how many books are being added (quantity), the price of the book, who published the book, when the books were received, information about the book and finally, the front cover of the book.
- A button to add the book to the database and one for clearing all the input fields to the default state (empty).
- A button to show the author list (next screenshot).

*Manage Books - Add Book - Author List*

![Author list](./docs/readme/AuthorListFormPicture.png)

Shows all authors in the database.
-User selects relevant author and clicks the button at the bottom.

*Manage Books - Edit Book*

![Manage books edit book](./docs/readme/ManageBooksEditBookPictureEntries.png)

Similar functionality to add book, with the addition of two "Search by" buttons and the edit button.
- Enter the book id you want to edit, then click "Search by ID" and the rest of the fields will auto-fill.
- This can also be done with the ISBN of the book, and the fields will auto fill.
- Edit book button will modify the book with the relevant ID with the fields entered.

*Manage Books - Delete Book*

![Manage books delete book](docs/readme/ManageBooksDeleteBookPicture.png)

Enter the ID of the book you want deleted, and it'll go poof in the database.

*Manage Books - Book List*

![Manage books book list](docs/readme/ManageBooksShowBookListPicture.png)

Displays all the books currently in the database.
- Edit selected book will take you to the "Edit a book" screen with input fields filled in automatically.
- Remove selected book is another way to delete books from the database.
- In both cases, the operation is done on whatever row is currently selected.



## Credits
