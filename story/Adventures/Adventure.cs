namespace story.Adventures
{
    public class Adventure
    {
        public string GUID { get; set; }
        public int MinmumLevel { get; set; }
        public int MaxLevel { get; set; }
        public int CompletionGoldReward { get; set; }    
        public int CompletionXPReward { get; set; }  
        public string Title { get; set; }
        public string Description { get; set; }

        public Adventure()
        {

        }

        /// <summary>
        /// This class does this and that and dont do this.
        /// </summary>
        public void myMethod()
        {

        }
    }
}
