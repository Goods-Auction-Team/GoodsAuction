using System.Diagnostics;
using system;
using boundry.Form;
package Control;

public class Control
{
	ArrayList<Form> formList;
	
	public Controller()
	{
		 formList = new ArrayList<Form>();
	}
	
	public void addForm(Form form) {
		formList.add(form);
	}
	
	//this method will return a desired form type from the list of forms
	public Form getForm(Object type) {
		
		Form form = null;
		
		for(int i = 0; i < formList.size(); i++)
		{
		    if(formList.get(i).getClass() == type.getClass());
		    	form = formList.get(i);
		}
		
		return form;
	}
}