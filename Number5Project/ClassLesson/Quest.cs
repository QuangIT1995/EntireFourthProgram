class Quest{
    public string quest_name {get; set;}
    public string description {get; set;}
    public float reward {get; set;}
    public string completion_status{get; set;}
    public Quest(string quest_name, string description, float reward, string completion_status){
        this.quest_name = quest_name;
        this.description = description;
        this.reward = reward;
        this.completion_status = completion_status;
    }
    public Quest(){
        this.quest_name = "Explore the warp";
        this.description = "Go to the warp and defeat the toasts";
        this.reward = 300;
        this.completion_status = "Not started";
    }
    public void start_the_quest(){
        if(this.completion_status == "Not started"){
            this.completion_status = "In progress";
            Console.WriteLine($"Quest name: {this.quest_name} has started");
        }
        else{
            Console.WriteLine($"Quest name:{this.quest_name} has not been started. Current status: {this.completion_status}");
        }
    }

    public void complete_the_quest(){
        if(this.completion_status == "In progress"){
            this.completion_status = "Completed";
            Console.WriteLine($"Quest name: {this.quest_name} has completed");
        }
        else{
            Console.WriteLine($"Quest name: {this.quest_name} has not completed. Current status: {this.completion_status}");
        }
    }

    public void claim_the_reward(){
        if(this.completion_status == "Completed"){
            this.completion_status = "Reward claimed";
            Console.WriteLine($"Reward: {this.reward}");
        }
        else{
            Console.WriteLine($"Reward cannot be claimed. Current status: {this.completion_status}");
        }
    }
}