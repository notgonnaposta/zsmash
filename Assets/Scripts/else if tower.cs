using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class elseiftower : MonoBehaviour
{
    public Text splashtext;
    public int r;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] splashes = new string[]
{
    "goto fail;",
    "true + true == 2! (Where JavaScript Available)",
    "Now with 80% less bugs (*sample size reduced by 80%)",
    "Written on AMD!",
    "In association with Bill Gates! (indirectly)",
    "It just works!",
    "Try the Linux port!",
    "Made by humans!",
    "Made for humans! (and smart apes)",
    "Consumes electricity!",
    "Thriller!",
    "More zombies than the leading brand!",
    "Playable on devices that have CPU's!",
    "verflowStackoverflowStac",
    "3L1t3 H4Xx0r5",
    "0x80085",
    "Built with Mono! (or il2cpp)",
    "Made with Unity!",
    "Will succumb to entropy!",
    "Splash screen text!",
    "This isn't randomized with an index!",
    "Press play to play!",
    "The \"Q\" button is unbound! (and also not needed to play)",
    "Press nothing to do nothing!",
    "Inspired by ZombieSmash!",
    "Try Minecraft!",
    "Try Terraria!",
    "Liam's birthday is June 11th!",
    "Won't try to execute noexecute memory!",
    "My apostrophe key isnt working!",
    "Now without th lttr btwn w & r!",
    "Nw wtht vwls!",
    "Now in CRLF!",
    "git commit -a",
    "git push origin master",
    "Try Goober Island!",
    "This is randomized via else if!",
    "Now sugar free!",
    "Artificially sweetened!",
    "Try Splenda! *This message not sponsored by splenda",
    "Now with atoms!",
    "All this thanks to silicon!",
    "Try Z-Smash... oh wait...",
    "Freaky!",
    "Non stick!",
    "Try TF2!",
    "I can believe it's not butter!",
    "Now with LF! (When Linux Available)",
    "Works on OSX!",
    "Programmed in C#!",
    "Made in America!",
    "Made on a 1080 Ti!",
    "Made by TEAM RGD!",
    "Works on everything! (sample size reduced to only include computers)",
    "Play at night for immersion!",
    "They've got Allen wrenches, gerbil feeders, toilet seats, electric heaters, Trash compactors, juice extractors, shower rods and water meters, Walkie-talkies, copper wires, safety goggles, radial tires, BB pellets, rubber mallets, fans and dehumidifiers, Picture hangers, paper cutters, waffle irons, window shutters, Paint removers, window louvers, masking tape and plastic guttersKitchen faucets, folding tables, weather stripping, jumper cablesHooks and tackle, grout and spackle, power foggers, spoons and ladlesPesticides for fumigation, high-performance lubricationMetal roofing, waterproofing, multi-purpose insulationAir compressors, brass connectors, wrecking chisels, smoke detectorsTire gauges, hamster cages, thermostats and bug deflectorsTrailer hitch demagnetizers, automatic circumcisersTennis rackets, angle brackets, Duracells and EnergizersSoffit panels, circuit breakers, vacuum cleaners, coffee makersCalculators, generators, matching salt and pepper shakers!",
    "Woah!",
    "Go watch Office Space!",
    "Thanks, Obama!",
    "Get out of my room I'm playing Z-Smash!",
    "Yellow pulsing text on a main menu screen!",
    "Suprised to see me?",
    "Hi!",
    "(:",
    "Now with 20% more exclamation marks!!!!!!!!!!!!!!!!!!",
    "Who you gonna call?",
    "Compatible with electrons!",
    "Now causes NaN less bugs! (fix that bug later)",
    "INACCESSIBLE_BOOT_DEVICE",
    "HLT!",
    "Wait, are there Zombies in this game?",
    "Don't press quit!",
    "Now with one refrence to Richard Nixon!",
    "NullRefrenceException",
    "?????????????????????",
    "File Not Found: Splashtext.txt",
    "Don't play this while driving!",
    "Don't drink and drive!",
    "Children!",
    "nop",
    "Not all code paths return values!",
    "All code paths return values!",
    "ootstrap paradox!",
    "Bo",
    "Now tries to read kernel memoryIRQL_NOT_LESS_OR_EQUAL",
    "Text!",
    "Say what?",
    "What?",
    "Huh?",
    "Gee, I sure wonder what this game is about....",
    "Check out our GitHub!",
    "Wikipedia! It's trustworthy!",
    "Zombie Stole The Precious Thing!",
    "Don't try Roblox!",
    "Written by me!",
    "Code written by code writer!",
    "This splash text is really fun to write!"
};
int r = Random.Range(0, splashes.Length);
splashtext.text = splashes[r];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
