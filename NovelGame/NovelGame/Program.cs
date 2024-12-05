using System;

class ThrillerSchoolGame
{
    static void Main(string[] args)
    {

        Console.WriteLine("The school is eerily quiet tonight. What's your name?");
        string playerName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(playerName))
        {
            playerName = "Any Name"; 
            Console.WriteLine("I don't see any name, so your name will be 'Any Name'. You hope this is enough to keep you safe tonight...");
        }
        else
        {
            Console.WriteLine($"Nice to meet you, {playerName}. But something feels off in this place...");
        }

        Console.WriteLine($"\n{playerName}, you were asleep in class. When you woke up, the classroom was empty. No one woke you up, and the halls are silent.");
        Console.WriteLine("You check your phone, but there's no signal. It's much darker outside than it should be. Something is definitely wrong.");

        int cautiousCount = 0;

        string answer1 = AskQuestion("\n1. You hear footsteps behind you in the empty hallway. Do you:",
                                     "A. Turn around and face whatever is there (1)",
                                     "B. Keep walking, pretending you heard nothing (2)");

        if (answer1 == "1")
        {
            Console.WriteLine("You turn around, but there's no one there... or so it seems.");
        }
        else
        {
            Console.WriteLine("You keep walking, your heart racing, hoping whatever it is doesn’t follow.");
            cautiousCount++;
        }

        string answer2 = AskQuestion("\n2. The school's lights flicker and go out. Do you:",
                                     "A. Try to find the circuit breaker in the basement (1)",
                                     "B. Use your phone's light and keep moving forward (2)");

        if (answer2 == "1")
        {
            Console.WriteLine("You head to the basement, the air getting colder as you descend.");
        }
        else
        {
            Console.WriteLine("Your phone light barely illuminates the dark, but it’s all you have.");
            cautiousCount++;
        }

        string answer3 = AskQuestion("\n3. A distant scream echoes through the halls. Do you:",
                                     "A. Follow the sound to investigate (1)",
                                     "B. Ignore it and try to find the nearest exit (2)");

        if (answer3 == "1")
        {
            Console.WriteLine("You follow the sound, though every instinct tells you not to.");
        }
        else
        {
            Console.WriteLine("You choose survival over curiosity, heading for the exit.");
            EndCautiousEnding(playerName);
            return; //Asked Chat GPT for skip the question 4 and end the game here.
        }


        string answer4 = AskQuestion("\n4. You come across a locked door, but you hear faint voices inside. Do you:",
                                     "A. Try to unlock the door (1)",
                                     "B. Walk away, not wanting to get involved (2)");

        if (answer4 == "1")
        {
            Console.WriteLine("You manage to unlock the door, but no one is there... just an empty room.");
        }
        else
        {
            Console.WriteLine("You walk away, the whispers growing faint behind you.");
            cautiousCount++;
        }

        if (cautiousCount == 4)
        {
            EndCautiousEnding(playerName);
        }
        else
        {
            FinalExtendedEnding(playerName);
        }
    }

    //Asked Chat GPT for this part because I didn't want to player give an answer besides 1 and 2.
    static string AskQuestion(string question, string option1, string option2)
    {
        string answer;
        do
        {
            Console.WriteLine(question);
            Console.WriteLine(option1);
            Console.WriteLine(option2);
            answer = Console.ReadLine();

            if (answer != "1" && answer != "2")
            {
                Console.WriteLine("Please answer it properly or you will get me angry.");
            }
        } while (answer != "1" && answer != "2");

        return answer;
    }

    //Asked Chat GPT for question 3 ending and continue to question 4. 
    static void EndCautiousEnding(string playerName)
    {
        Console.WriteLine($"\nThanks for playing, {playerName}.");
        Console.WriteLine("You were cautious, but the mysteries of this school remain unsolved.");
        Console.WriteLine("As you step out into the cool night air, you can't help but feel watched... but at least you're safe. For now.");
        Console.WriteLine("Game Over.");
    }

    static void FinalExtendedEnding(string playerName)
    {
        Console.WriteLine("\nYou made some cautious decisions, but curiosity kept you going...");

        Console.WriteLine($"\nAs you continue exploring, you find yourself in front of a door marked 'Staff Only'. A chill runs down your spine.");
        Console.WriteLine("Before you can react, the door creaks open by itself.");

        Console.WriteLine($"\nDo you:");
        Console.WriteLine("A. Enter the room to investigate (1)");
        Console.WriteLine("B. Turn around and leave the school immediately (2)");
        string finalAnswer = Console.ReadLine();

        if (finalAnswer == "1")
        {
            Console.WriteLine("You step into the room. The door slams shut behind you, and you're engulfed in darkness. A voice whispers, \"You're too late.\"");
            Console.WriteLine("\nGame Over. The school’s secrets remain hidden... but you can't learn anymore.");
        }
        else
        {
            Console.WriteLine("You turn and leave the school, stepping into the night. But as you walk home, you can't shake the feeling that someone—or something—is following you.");
            Console.WriteLine("\nGame Over. You escaped, but the school’s mysteries still haunt you.");
        }
    }
}

