namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// Getting Started
//
// The F# Koans are a set of exercises designed to get you familiar
// with F#. By the time you're done, you'll have a basic
// understanding of the syntax of F# and learn a little more
// about functional programming in general.
//
// Answering Problems
//
// This is where the fun begins! Each Koan method contains
// an example designed to teach you a lesson about the F# language.
// If you execute the program defined in this project, you will get
// a message that the AssertEquality koan below has failed. Your
// job is to fill in the blank (the __ symbol) to make it pass. Once
// you make the change, re-run the program to make sure the koan
// passes, and continue on to the next failing koan.  With each
// passing koan, you'll learn more about F#, and add another
// weapon to your F# programming arsenal.
//---------------------------------------------------------------

[<Koan(Sort = 1)>]
module KoansExercise =

    let nl = System.Environment.NewLine

    [<Koan>]
    let MakeAStairCase() =
        // This is a staircase of size :

        //    #
        //   ##
        //  ###
        // ####
        // Its base and height are both equal to n. It is drawn using # symbols and spaces. The last line is not preceded by any spaces.

        // Write a program that prints a staircase of size n.

        let makeStairCase n =
            let listOfStrings =
                [ for x in 1 .. n do
                    let row =
                        [ for y in 1 .. n do
                            if y > x then
                                yield " "
                            else
                                yield "#" ]
                        |> List.rev
                    yield String.concat "" row ]
            String.concat nl listOfStrings

        let stairCase1 =  "#"
        let stairCase2 =
            " #" + nl +
            "##"
        let stairCase5 =
            "    #" + nl +
            "   ##" + nl +
            "  ###" + nl +
            " ####" + nl +
            "#####"
        let stairCase7 =
            "      #" + nl +
            "     ##" + nl +
            "    ###" + nl +
            "   ####" + nl +
            "  #####" + nl +
            " ######" + nl +
            "#######"


        AssertEquality stairCase1 (makeStairCase 1)
        AssertEquality stairCase2 (makeStairCase 2)
        AssertEquality stairCase5 (makeStairCase 5)
        AssertEquality stairCase7 (makeStairCase 7)

    [<Koan>]
    let TwelveHourClockConversion() =
        // Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

        // Note:
        // - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        // - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
        // Don't use .NET's time APIs (it will probably be easier not to)

        let convertTime time =
            let str = string time
            if(str.Contains("PM"))then
                let s = 
                    if(str.[0] = '1' && str.[1] = '2')then
                        str
                    else
                        string (12 + ((int str.[0] - 48)*10) + (int str.[1] - 48)) + str.Remove(0,2) 
                    
                s.Remove(str.IndexOf("PM"))
            else
                 if(str.[0] = '1' && str.[1] = '2')then
                        let s = "00" + str.Remove(0,2) 
                        s.Remove(str.IndexOf("AM"))
                 else
                        str.Remove(str.IndexOf("AM"))
                    
            

        AssertEquality "10:55:01" (convertTime "10:55:01AM")
        AssertEquality "19:05:45" (convertTime "07:05:45PM")
        AssertEquality "12:01:32" (convertTime "12:01:32PM")
        AssertEquality "00:46:52" (convertTime "12:46:52AM")



    [<Koan>]
    let FizzBuzzCodingTest() =
        // The FizzBuzz problem is a classic test given in coding interviews. The task
        // is simple: Print integers 1 to N, but print “Fizz” if an integer is divisible
        // by 3, “Buzz” if an integer is divisible by 5, and “FizzBuzz” if an integer
        // is divisible by both 3 and 5. In this case the results should be in the form
        // of an F# list.

        let fizzBuzzList n =
            [for x in 1..n do
                match x with
                | x when x%3=0 && x%5=0 -> yield "Fizzbuzz"
                | x when x%3=0  -> yield "Fizz"
                | x when x%5=0 -> yield "Buzz"
                | _ -> yield string x
            ]

        let result = ["1"; "2"; "Fizz"; "4"; "Buzz"; "Fizz"; "7"; "8"; "Fizz"; "Buzz"; "11"; "Fizz"; "13"; "14"; "Fizzbuzz"; "16"; "17"; "Fizz"; "19"; "Buzz"]

        AssertEquality result (fizzBuzzList 20)

    [<Koan>]
    let MaxMinSum() =
        // Given five positive integers, find the minimum and maximum values that can be calculated by
        // summing exactly four of the five integers. Then print the respective minimum and maximum
        // values as a single line of two space-separated long integers.

        let calculateMaxMin centimes =
            __

        AssertEquality (16, 24) (calculateMaxMin [1;3;5;7;9])
        AssertEquality (10, 14) (calculateMaxMin [1;2;4;5])


    type Coins =
        | Cents50
        | Cents20
        | Cents10
        | Cents05
        | Cents02
        | Cents01

    [<Koan>]
    let OptimumCorrectChange() =
        // customers always prefer the smallerst number of coins
        // calculate the smallest number coins that can be given
        // when paying for something with a one euro coin

        let getChangeFromOneEuro centimes =
            __

        AssertEquality [Cents50] (getChangeFromOneEuro 50)
        AssertEquality [Cents20] (getChangeFromOneEuro 80)
        AssertEquality [Cents50; Cents01] (getChangeFromOneEuro 49)
        AssertEquality [Cents20; Cents02] (getChangeFromOneEuro 78)
        AssertEquality [Cents20; Cents02] (getChangeFromOneEuro 78)
        AssertEquality [Cents20; Cents02; Cents01] (getChangeFromOneEuro 77)
        AssertEquality [Cents02; Cents02] (getChangeFromOneEuro 96)

    [<Koan>]
    let BirdSightings() =
        // Given an array of bird sightings where every element represents a bird type
        // id, determine the id of the most frequently sighted type. If more than 1 type
        // has been spotted that maximum amount, return the smallest of their ids.

        // Example [1;1;2;2;3]

        // There are two each of types 1 and 2, and one sighting of type 3. Pick the lower of the two types seen twice: type 1.

        let getSittings sightings =
            __

        AssertEquality 4 (getSittings [1; 4; 4; 4; 5; 3])
        AssertEquality 3 (getSittings [1; 2; 3; 4; 5; 4; 3; 2; 1; 3; 4])

    open System

    [<Koan>]
    let XkcdDatew() =
        // XKCD is published Monday, Wednesday and Friday.
        // 2564 was published Wendesday 05 January 2022
        // Create a function to calculate the publication date
        // of any cartoon published after 2564


        // This time, using the .NET Date APIs is the right thing to do

        let getPublicationDate n =
            __

        AssertEquality (new DateTime(2022, 01, 05)) (getPublicationDate 2564)
        AssertEquality (new DateTime(2022, 01, 07)) (getPublicationDate 2565)
        AssertEquality (new DateTime(2024, 10, 18)) (getPublicationDate 3000)
        AssertEquality (new DateTime(2037, 08, 26)) (getPublicationDate 5012)

