﻿using SchoolLibraly.DAL.Entityes;

namespace SchoolLibraly.Services.Interfaces
{
    internal interface IUserDialog
    {
        bool Edit(Book book);

        bool ConfirmInformation(string Information, string Caption);
        bool ConfirmWarning(string Warning, string Caption);
        bool ConfirmError(string Error, string Caption);
    }
}
