package com.elsevier.education;

/**

TODO: Make this class immutable.

*/
public class Exercise1 {

	public static class Person {
		
		private Set<String> phoneNumbers;
		private String firstName;
		private String lastName;
		
		public Person() {
		}

		public Set<String> getPhoneNumbers() {
			return phoneNumbers;
		}
		public void setPhoneNumbers(Set<String> newPhoneNumbers) {
			phoneNumbers = newPhoneNumbers;
		}
		
		public String getFirstName() {
			return firstName;
		}
		public void setFirstName(String newName) {
			firstName = newName;
		}
		
		public String getLastName() {
			return lastName;
		}
		public void setLastName(String newName) {
			lastName = newName;
		}
	}
}