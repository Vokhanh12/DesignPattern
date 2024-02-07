namespace ChatRoomObserver.Notifiers
{
    class ChatRoom : Subject
    {
        private string _messageBox;
        private string _author;


        public string getMessageBox => _messageBox;
        
        public void setMessangeBox(string value)
        {
            _messageBox = value;
            chatRoomDataChanged();

        }

        public string getAuthor => _author;

        public void setAuthor(String value)
        {
            _author = value;
            chatRoomDataChanged();
        }



        public void chatRoomDataChanged()
        {
            notify(this,null);
        }

       
    }
}