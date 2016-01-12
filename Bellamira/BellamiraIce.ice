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
		string login;
		string password;
		string fam;
		string name;
		string otch;
		UserType type;
		Group group;
	};

	struct TimeTableEntry
	{
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

	exception UserAlreadyExists {};

	interface Entry 
	{
		Session * login(string name, string password) throws UserAlreadyExists;		
		string Test();
		Session * Register(User user) throws UserAlreadyExists;
	};

	interface Session 
	{
		UserManager * getUserManager();
		GroupManager *  getGroupManager();
		TimeTableManager * getTimeTableManager();
	};

	interface UserManager  
	{
		users getAllUsers();
        User getUser(string login);
        bool addUser(User u);
        bool delUser(string login);
        bool modifyUser(User u, string login);

        userTypes getAllUserTypes();
        UserType getUserType(string nameType);
        bool addUserType(UserType ut);
        bool delUserType(string login);
        bool modifyUserType(UserType ut, string login);
	};

	interface GroupManager
	{
		groups getAllGroups();
		Group getGroup(int idGr);
		Group getGroupbyName(string nameGroup);
		bool addGroup(Group gp);
		bool delGroup(int idGr);
		bool modifyGroup(Group gp,int idGr);  
		bool addUserInGroup(User u, int idGr);
		bool delUserFromGroup(User u, int idGr);
	};

	interface TimeTableManager
	{
		timeTable getAllTimeTable();
		timeTable getTimeTableForGroup(Group gp);
		bool addTimeTableEntry(TimeTableEntry te);
		bool delTimeTableEntry(int id);
		bool modifyTimeTableEntry(TimeTableEntry te, int id);	
	};

};
