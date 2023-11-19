﻿using Contacts.WebAPI.Domain;

namespace Contacts.WebAPI.Infrastructure;

public interface IContactsRepository
{
    Task<IEnumerable<Contact>> GetContactsAsync(string? search);
    Task<Contact?> GetContactAsync(int id);
    Task CreateContactAsync(Contact contact);
    bool UpdateContact(Contact contact);
    bool DeleteContact(int id);
}