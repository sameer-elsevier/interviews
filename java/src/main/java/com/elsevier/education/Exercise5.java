package com.elsevier.education;

/**

TODO: Make this class Singleton and modify main method to call doSomething method.

*/
public class Exercise5 {
	
	public static class Singleton {
		
		public void doSomeThing() {

			System.out.println("Doing some thing....");
	    }
		
		public static void main(String a[]){
			Singleton st = new Singleton();
	        st.doSomeThing();
	    }
	}
}
