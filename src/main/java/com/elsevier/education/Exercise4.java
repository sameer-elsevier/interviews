package com.elsevier.education;

/**

TODO Could the following class have a race condition? If not, why not, and if so, how could we fix it?

*/
public class Exercise4 {

	public static class Counter {
		
		private int count = 0;
		
		/**
		 * increment the count and return the new value.
		 */
		public int increment() {
			count++;
			return count;
		}
		
		public int getCount() {
			return count;
		}
		
		public void resetCount() {
			count = 0;
		}

	}
}