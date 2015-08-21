module Bellamira 
{
class User;

struct Group
{
	int id;
        string nameGroup;
        User teacher;
        User helper;  
};

struct UserType
{ 
	 int id;
     string nameType;
};

	class User
	{	
		int id;
        string fam;
        string name;
        string otch;
        UserType type;
        Group group;
	};

	struct TimeTableEntry{
	    int id;
        string dayWeek;
        long time;
        Group group;
	};

	interface Session;
	interface  UserManager;
	interface GroupManager;
	interface TimeTableManager;

	sequence<User> users;
	sequence<UserType> userTypes;
	sequence<Group> groups;
	sequence<TimeTableEntry> timeTable;

	interface Entry 
	{
		Session * login(string name, string password);		
	};

	interface Session 
	{
		UserManager getUserManager();
		GroupManager getGroupManager();
		TimeTableManager getTimeTableManager();
	};

	interface UserManager  
	{
	users	getAllUsers();
	User getUser(int  id);
	bool addUser(User u);
	bool delUser(int id);
	bool modifyUser(User u, int id);


	userTypes	getAllUserTypes();
	UserType   getUserType(int  id);
	bool addUserType(UserType ut);
	bool delUserType(int id);
	bool modifyUserType(UserType ut, int id);
	};

 interface GroupManager{

	groups getAllGroups();
    Group getGroup(int id);
	bool addGroup(Group gp);
	bool delGroup(int id);
	bool modifyGroup(Group gp,int id);  
	bool addUserInGroup(User u, int idGr);
	bool delUserFromGroup(User u, int idGr);
 };

 interface TimeTableManager{
 timeTable getAllTimeTable();
 timeTable getTimeTableForGroup(Group gp);
 bool addTimeTableEntry(TimeTableEntry te);
 bool delTimeTableEntry(int id);
bool modifyTimeTableEntry(TimeTableEntry te, int id);	
 };

};