using System.Speech.Synthesis;

// Initialize a new instance of the SpeechSynthesizer.  
SpeechSynthesizer synth = new SpeechSynthesizer();

// Configure the audio output.   
synth.SetOutputToDefaultAudioDevice();

//synth.SelectVoiceByHints(VoiceGender.Female);

// Speak a string.  
synth.Speak("Hello this is a code example demonstrating text to speech.");

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();