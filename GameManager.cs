using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDTextGame
{
    public class GameManager
    {
        private string _currentState;
        private bool _lastInputInvalid;

        public GameManager()
        {
            _currentState = "start";
            _lastInputInvalid = false;
        }

        
        public string GetGameState()
        {
            return _currentState; // Expose the current state
        }
        

        public string GetGameOutput()
        {
            string output = "";

            if (_lastInputInvalid)
            {
                output += "That is not a valid action. Please try again.\n\n";
                _lastInputInvalid = false;
            }

            switch (_currentState)
            {
                case "start":
                    output += "You awaken in a dark, damp cave. A faint light shines from two passages: one to your [left] and one to your [right]. What do you do?";
                    break;
                case "left_passage":
                    output += "You cautiously enter the left passage. It narrows considerably, and you hear dripping water. Suddenly, a small [goblin] jumps out! What do you do?";
                    break;
                case "right_passage":
                    output += "You choose the right passage. It's surprisingly warm and opens into a large cavern. In the center is a sparkling [chest]. What do you do?";
                    break;
                case "fight_goblin":
                    output += "You bravely attack the goblin! It's surprised and quickly defeated. You find a rusty [key] on its body. What now?";
                    break;
                case "open_chest":
                    output += "You try to open the chest, but it's locked. Maybe there's a [key] nearby?";
                    break;
                case "use_key":
                    output += "You use the rusty key! The chest clicks open, revealing a pile of gold! You win! (Type 'restart' to play again)";
                    break;
                case "restart":
                    _currentState = "start";
                    output += "Game restarted.\n\n";
                    output += GetGameOutput(); // This will get the new 'start' text
                    break;
                default:
                    output += "An error occurred. The game state is unknown.";
                    break;
            }
            return output;
        }

        public void ProcessPlayerInput(string input)
        {
            input = input.ToLower().Trim();

            bool inputHandled = false;

            switch (_currentState)
            {
                case "start":
                    if (input == "left")
                    {
                        _currentState = "left_passage";
                        inputHandled = true;
                    }
                    else if (input == "right")
                    {
                        _currentState = "right_passage";
                        inputHandled = true;
                    }
                    break;
                case "left_passage":
                    if (input == "goblin" || input == "fight")
                    {
                        _currentState = "fight_goblin";
                        inputHandled = true;
                    }
                    break;
                case "right_passage":
                    if (input == "chest" || input == "open")
                    {
                        _currentState = "open_chest";
                        inputHandled = true;
                    }
                    break;
                case "fight_goblin":
                    if (input == "key" || input == "take key" || input == "take")
                    {
                        _currentState = "open_chest";
                        inputHandled = true;
                    }
                    else if (input == "restart")
                    {
                        _currentState = "restart";
                        inputHandled = true;
                    }
                    break;
                case "open_chest":
                    if (input == "key" || input == "use key")
                    {
                        _currentState = "use_key";
                        inputHandled = true;
                    }
                    else if (input == "restart")
                    {
                        _currentState = "restart";
                        inputHandled = true;
                    }
                    break;
                case "use_key":
                    if (input == "restart")
                    {
                        _currentState = "restart";
                        inputHandled = true;
                    }
                    break;
                case "restart":
                    break;
            }

            if (!inputHandled)
            {
                _lastInputInvalid = true;
            }
        }
    }
}