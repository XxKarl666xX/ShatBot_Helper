
# ShatBot_Helper

**How do I use this?**

Just start the exe which is located inside "bin" under "Release" and your good to start asking your dumb questions to ShatBot

**"What is this?"**

This is a simple concept for a Xbox 360 support tool

**"How does it work?"**

By using machine learning one can create a custom model that can recognize patterns in text and evaluate the most likely correct match for said text.

By creating a custom model that is fed with basic Xbox 360 modding related questions one can create a model that detects those questions and give a pre-determined answer to those questions from the match

**"Why tho?"**

I still see many basic questions from people who just started with Xbox 360 modding. It would be way smarted to just creaate some sort of support tool that could answer those basic questions instead of wasting more time and patience from people to answer these questions all over again. Also, those people are too dumb to use YouTube...

**"But im quite dumb and dont know how any of this machine learning stuff works..."**

Dont worry, its very easy to make the ShatBot "smarter" yourself WITHOUT ANY CODING KNOWLEDGE!

Just feed into the "chatbot_data.csv" more data.

The formatting is as followed: "text","label"

After you implemented new test data you can simply use the tool to train the new model on the test data you just updated, wait a few seconds to let it complete training and thats it, you created with that your new model that is in whatever way better or worse.

Keep both the "chatbot_data.csv" and the "chatbot_model.zip" on your desktop. The tool expects both these files in that location, you can easily change that by editing the path inside the code yourself, or hope that I might add a path selection of some sorts in the future
