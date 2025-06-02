
Classroom Battle Simulator  
Version: 1.0  
JOHN MICKYL SUMAGANG
EYA NICOLE BARCENA 
NUR AISHA CAYAGO

--------------------------------------------------
🛡️ Characters Overview:
--------------------------------------------------

1. Science Swordy  
   - Description: A valiant knight of science, armed with knowledge and powerful experiments. He delivers scientific justice using "Chemical Burn," "Heal," and the devastating "Physics Punch."  
   - Role: Uses scientific-based attacks and healing abilities to weaken enemies and sustain himself in battle.

2. The Englisher  
   - Description: A shadowy ninja master of language and literature. With wordplay and grammatical force, he attacks using "Book Smack" and "Letter Dumping," and can also heal when needed.  
   - Role: Balances literary-themed offense and support abilities.

3. Math Wizard  
   - Description: A magical master of numbers, formulas, and logic. He casts spells like "Calculate stike" and "Logic kick" to cause numerical havoc on enemies.  
   - Role: Focuses on high-damage calculations and critical hits, with occasional defensive maneuvers.

4. History Buff Brawler  
   - Description: A rugged fighter fueled by tales of the past, wielding historical knowledge like a weapon. Uses attacks like "Time blast" and "Sword slash" to overwhelm opponents.  
   - Role: A tough melee fighter with strong, consistent attacks and occasional buffs drawn from legendary figures of history.
--------------------------------------------------
🔄 Object-Oriented Programming (OOP) Principles Applied:
--------------------------------------------------

1. Encapsulation  
   - Each character’s properties (health, attack power, defense state) are kept private within their respective classes.
   - Public methods are used to interact with and manipulate character state, ensuring that internal data is protected from unintended interference.

2. Abstraction  
   - Shared actions like Attack, Heal, and Defend are abstracted into a base class.
   - Each derived character class implements these actions in a way that reflects their unique identity (e.g., Physics Punch for Science Swordy, Book Smack for The Englisher).

3. Inheritance  
   - A base class called "Character" (or similar) contains common attributes and methods shared by all characters.
   - Science Swordy and The Englisher inherit from this base class and override or extend functionality where needed.

4. Polymorphism  
   - Methods such as `PerformMove()` are polymorphic: the same method call executes different code depending on the object’s actual class.
   - This allows for flexible interaction between game logic and UI, without knowing which specific character is acting.

--------------------------------------------------
⚠️ Challenges Faced:
--------------------------------------------------

1. Balancing Character Skills  
   - Ensuring fair gameplay between Science Swordy and The Englisher required tweaking damage values, heal amounts, and move availability. Some moves were too weak or overpowered during early tests.

2. Turn-Based Logic  
   - Managing the turn system and making sure buttons enabled/disabled correctly depending on whose turn it was took careful control of game state and UI components.

3. UI and Backend Integration  
   - Integrating OOP-based game logic into the WinForms interface was a challenge, especially avoiding tightly coupling the form with character logic.
   - Clear separation of concerns was required to make the code modular and maintainable.

4. Button Availability and Game Flow  
   - Handling user input, disabling actions at the right moments, and reflecting changes instantly on the UI were necessary to create a smooth game experience.

--------------------------------------------------
💡 Notes:
--------------------------------------------------

- This game was developed to demonstrate object-oriented design in a fun and interactive format.
- The characters, abilities, and themes are classroom-inspired to make learning engaging.
- This project served as both a programming exercise and a playful way to visualize turn-based combat.

Thank you for playing Classroom Battle Simulator!
