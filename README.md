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

How to Use the Chatbot
- Launch the application - Voice greeting plays automatically
- View the ASCII logo - Cybersecurity-themed ASCII art displays
- Enter your name - Type your name when prompted
- Ask questions - Type your cybersecurity questions
- Exit - Type 'exit' or 'quit' to end

Example Questions to Ask:
General Questions:
- "How are you?"
- "What's your purpose?"
- "What can I ask you about?"

Password Safety:
- "Tell me about passwords"
- "How do I create a strong password?"
- "Password safety tips"

Phishing:
- "What is phishing?"
- "How to spot a scam email?"
- "Phishing email red flags"

Safe Browsing:
- "How do I browse safely?"
- "Safe browsing tips"
- "How to know if a website is safe?"

GitHub Actions CI/CD
This repository uses GitHub Actions for Continuous Integration. The workflow:
Triggers: On every push to main/master branch
Runs on: Windows-latest (for System.Media support)
Checks:
Restores NuGet dependencies
Builds the project in Release configuration
Verifies successful compilation

CI Workflow Status
<img width="1894" height="950" alt="image" src="https://github.com/user-attachments/assets/969b6f01-ef8b-408d-89ad-a2adc1a91f7e" />

Commit History

The repository contains 6+ meaningful commits:
1. Initial commit: Set up project structure
2. Added voice greeting functionality
3. Added ASCII art display from JPEG
4. Added user name collection with validation
5. Implemented basic response system
6. Added split functions for string parsing
7. Added typing effect with character delays
8. Added GitHub Actions CI workflow

Video Presentation
An unlisted YouTube video presentation is available demonstrating:
Full application functionality
Code structure explanation
Logic and flow demonstration
Voice greeting playback
ASCII art display
Typing effect in action
Conversation examples

YOUTUBE Video link: You Tube video link
https://youtu.be/DzL08JbXbDg 

Technologies Used
Language: C# (.NET 6.0)
Audio: System.Media.SoundPlayer
Image Processing: System.Drawing
Version Control: Git & GitHub
CI/CD: GitHub Actions
