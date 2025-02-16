// Define the Contact interface
interface Contact {
    id: number;
    name: string;
    email: string;
    phone: string;
}

// ContactManager class to manage contacts
class ContactManager {
    private contacts: Contact[] = [];

    // Add a new contact
    addContact(contact: Contact): void {
        this.contacts.push(contact);
        console.log(`Contact with ID ${contact.id} added successfully.`);
    }

    // View all contacts
    viewContacts(): Contact[] {
        return this.contacts;
    }

    // Modify an existing contact
    modifyContact(id: number, updatedContact: Partial<Contact>): void {
        const contactIndex = this.contacts.findIndex(contact => contact.id === id);
        if (contactIndex === -1) {
            console.error(`Error: Contact with ID ${id} does not exist.`);
            return;
        }

        this.contacts[contactIndex] = {
            ...this.contacts[contactIndex],
            ...updatedContact
        };
        console.log(`Contact with ID ${id} modified successfully.`);
    }

    // Delete a contact
    deleteContact(id: number): void {
        const contactIndex = this.contacts.findIndex(contact => contact.id === id);
        if (contactIndex === -1) {
            console.error(`Error: Contact with ID ${id} does not exist.`);
            return;
        }

        this.contacts.splice(contactIndex, 1);
        console.log(`Contact with ID ${id} deleted successfully.`);
    }
}

// Testing the ContactManager functionality
const manager = new ContactManager();

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
