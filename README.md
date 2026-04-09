# Cybersecurity Awareness Chatbot - Valerie

## Project Overview

This is a **Cybersecurity Awareness Chatbot** developed for South African citizens as part of a cybersecurity education campaign. The chatbot, named "Valerie", provides interactive education about online safety practices including password safety, phishing detection, and safe browsing habits.

## Features

### Part 1 Features:
- 🎵 **Voice Greeting** - Plays a recorded WAV audio greeting when the application starts
- 🎨 **ASCII Art Display** - Shows a cybersecurity-themed logo converted from JPEG to ASCII art
- 💬 **Personalized Interaction** - Asks for and uses the user's name throughout the conversation
- 🔐 **Cybersecurity Education** - Provides information about:
  - Password safety and best practices
  - Phishing email detection
  - Safe browsing habits
- 🧠 **Input Validation** - Handles empty inputs and unrecognized questions gracefully
- 🎨 **Enhanced Console UI** - Colored text, borders, and structured formatting
- 🔧 **String Manipulation** - Uses split functions to analyze user input
- 🔄 **Continuous Conversation** - Loop-based interaction until user types 'exit' or 'quit'

## Technical Requirements Met

- ✅ Command-line application
- ✅ Voice greeting using System.Media
- ✅ ASCII art image display
- ✅ User name collection and personalization
- ✅ Basic response system with if/else logic
- ✅ Input validation for empty entries
- ✅ Colored console output
- ✅ Split function for string manipulation
- ✅ Object-oriented design with multiple classes
- ✅ GitHub version control (6+ commits)
- ✅ GitHub Actions CI workflow

## Project Structure
cybersecurity_awareness_chatbot/
├── Program.cs # Main entry point
├── voice_greeting.cs # Handles WAV audio playback
├── ascii_logo.cs # Converts and displays ASCII art from JPEG
├── welcome_username.cs # Gets and validates user name
├── response_system.cs # Core response and conversation logic
├── voice_recording.wav # Voice greeting audio file
├── logo.jpeg # Source image for ASCII art
└── README.md # This file


## Class Descriptions

### Program.cs
- Main entry point of the application
- Orchestrates the initialization of all components
- Creates instances of voice_greeting, ascii_logo, welcome_username, and response_system

### voice_greeting.cs
- Plays a WAV audio greeting when the application launches
- Uses `System.Media.SoundPlayer` class
- Includes error handling for missing audio files

### ascii_logo.cs
- Reads a JPEG image file
- Converts the image to grayscale
- Maps pixel values to ASCII characters
- Displays the ASCII art in the console

### welcome_username.cs
- Displays a welcome message with decorative borders
- Prompts the user for their name
- Validates that the name is not empty
- Uses a do-while loop for input validation
- Returns the username to other classes

### response_system.cs
- Main conversation handler
- Implements split functions for string parsing
- Contains response methods for cybersecurity topics
- Handles the main conversation loop
- Provides default responses for unrecognized queries

## Key Methods in response_system.cs

### Split Functions:
- `split_user_input()` - Splits user input into individual words
- `count_words_in_input()` - Counts total words in input
- `display_split_words()` - Shows split words for debugging
- `contains_word()` - Checks if a specific word exists
- `get_first_word()` - Extracts the first word
- `extract_main_topic()` - Identifies the main cybersecurity topic

### Response Methods:
- `get_how_are_you_response()` - Response to "How are you?"
- `get_purpose_response()` - Explains the chatbot's purpose
- `get_topics_response()` - Lists available topics
- `get_password_safety_response()` - Password safety tips
- `get_phishing_response()` - Phishing detection tips
- `get_safe_browsing_response()` - Safe browsing habits
- `get_default_response()` - Default response for unrecognized input

### Prerequisites:
- Windows Operating System
- .NET Framework
- Visual Studio
