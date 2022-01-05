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

    [<Koan>]
    let CreatingListsWithComprehensions() =
        let list = [for i in 0..4 do yield i ]

        AssertEquality list __

    [<Koan>]
    let ComprehensionsWithConditions() =
        let list = [for i in 0..10 do
                        if i % 2 = 0 then yield i ]

        AssertEquality list __

    [<Koan>]
    let TransformingListsWithMap() =
        let square x =
            x * x

        let original = [0..5]
        let result = List.map square original

        AssertEquality original __
        AssertEquality result __

    [<Koan>]
    let FilteringListsWithFilter() =
        let isEven x =
            x % 2 = 0

        let original = [0..5]
        let result = List.filter isEven original

        AssertEquality original __
        AssertEquality result __

    [<Koan>]
    let DividingListsWithPartition() =
        let isOdd x =
            x % 2 <> 0

        let original = [0..5]
        let result1, result2 = List.partition isOdd original

        AssertEquality result1 __
        AssertEquality result2 __

    [<Koan>]
    let CreatingArrays() =
        let fruits = [| "apple"; "pear"; "peach"|]

        AssertEquality fruits.[0] __
        AssertEquality fruits.[1] __
        AssertEquality fruits.[2] __

    [<Koan>]
    let ArraysAreMutable() =
        let fruits = [| "apple"; "pear" |]
        fruits.[1] <- "peach"

        AssertEquality fruits __

    [<Koan>]
    let YouCanCreateArraysWithComprehensions() =
        let numbers =
            [| for i in 0..10 do
                   if i % 2 = 0 then yield i |]

        AssertEquality numbers __

    [<Koan>]
    let ThereAreAlsoSomeOperationsYouCanPerformOnArrays() =
        let cube x =
            x * x * x

        let original = [| 0..5 |]
        let result = Array.map cube original

        AssertEquality original __
        AssertEquality result __

    [<Koan>]
    let SkippingElements() =
        let original = [0..5]
        let result = Seq.skip 2 original

        AssertEquality result __

    [<Koan>]
    let FindingTheMax() =
        let values = new ResizeArray<int>()

        values.Add(11)
        values.Add(20)
        values.Add(4)
        values.Add(2)
        values.Add(3)

        let result = Seq.max values

        AssertEquality result __

    [<Koan>]
    let FindingTheMaxUsingACondition() =
        let getNameLength (name:string) =
            name.Length

        let names = [| "Harry"; "Lloyd"; "Nicholas"; "Mary"; "Joe"; |]
        let result = Seq.maxBy getNameLength names

        AssertEquality result __

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
            __

        let stairCase1 =  "#"
        let stairCase2 =
            " #" + nl +
            "##" + nl
        let stairCase5 =
            "    #" + nl +
            "   ##" + nl +
            "  ###" + nl +
            " ####" + nl +
            "#####" + nl
        let stairCase7 =
            "      #" + nl +
            "     ##" + nl +
            "    ###" + nl +
            "   ####" + nl +
            "  #####" + nl +
            " ######" + nl +
            "#######" + nl


        AssertEquality stairCase1 (makeStairCase 1)
        AssertEquality stairCase2 (makeStairCase 2)
        AssertEquality stairCase5 (makeStairCase 5)
        AssertEquality stairCase7 (makeStairCase 7)

    let TwelveHourClockConversion() =
        // Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

        // Note:
        // - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        // - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
        // Don't use .NET's time APIs (it will probably be easier not to)

        let convertTime time =
            __

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
            __

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

