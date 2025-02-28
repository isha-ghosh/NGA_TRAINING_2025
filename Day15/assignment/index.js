var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
// ContactManager class to manage contacts
var ContactManager = /** @class */ (function () {
    function ContactManager() {
        this.contacts = [];
    }
    // Add a new contact
    ContactManager.prototype.addContact = function (contact) {
        this.contacts.push(contact);
        console.log("Contact with ID ".concat(contact.id, " added successfully."));
    };
    // View all contacts
    ContactManager.prototype.viewContacts = function () {
        return this.contacts;
    };
    // Modify an existing contact
    ContactManager.prototype.modifyContact = function (id, updatedContact) {
        var contactIndex = this.contacts.findIndex(function (contact) { return contact.id === id; });
        if (contactIndex === -1) {
            console.error("Error: Contact with ID ".concat(id, " does not exist."));
            return;
        }
        this.contacts[contactIndex] = __assign(__assign({}, this.contacts[contactIndex]), updatedContact);
        console.log("Contact with ID ".concat(id, " modified successfully."));
    };
    // Delete a contact
    ContactManager.prototype.deleteContact = function (id) {
        var contactIndex = this.contacts.findIndex(function (contact) { return contact.id === id; });
        if (contactIndex === -1) {
            console.error("Error: Contact with ID ".concat(id, " does not exist."));
            return;
        }
        this.contacts.splice(contactIndex, 1);
        console.log("Contact with ID ".concat(id, " deleted successfully."));
    };
    return ContactManager;
}());
// Testing the ContactManager functionality
var manager = new ContactManager();
// Adding contacts
manager.addContact({ id: 1, name: 'Shane DSouza', email: 'shanedsouza@outlook.com', phone: '123-456-7890' });
manager.addContact({ id: 2, name: 'Ana Huang', email: 'huang.ana@gmail.com', phone: '987-654-3210' });
manager.addContact({ id: 3, name: 'Alexander DCruz', email: 'alex.cruz23@gmail.com', phone: '987-654-3210' });
// Viewing contacts
console.log('All Contacts:', manager.viewContacts());
// Modifying a contact
manager.modifyContact(1, { phone: '111-222-3333' });
// Viewing contacts after modification
console.log('Contacts after modification:', manager.viewContacts());
// Deleting a contact
manager.deleteContact(2);
// Viewing contacts after deletion
console.log('Contacts after deletion:', manager.viewContacts());
// Attempting to modify a non-existent contact
manager.modifyContact(3, { name: 'Non Existent' });
// Attempting to delete a non-existent contact
manager.deleteContact(3);
