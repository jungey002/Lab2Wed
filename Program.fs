type CoachInfo = {
    Name: string
    IsFormerPlayer: bool
}

type PerformanceStats = {
    NumberOfWins: int
    NumberOfLosses: int
}

type BasketballTeam = {
    TeamName: string
    HeadCoach: CoachInfo
    Performance: PerformanceStats
}

let coachA = { Name = "Steve Kerr"; IsFormerPlayer = false }
let coachB = { Name = "Billy Donovan"; IsFormerPlayer = true }
let coachC = { Name = "Joe Mazzulla"; IsFormerPlayer = true }
let coachD = { Name = "Magic Johnson"; IsFormerPlayer = false }
let coachE = { Name = "Nick Nurse"; IsFormerPlayer = true }

let performanceA = { NumberOfWins = 44; NumberOfLosses = 16 }
let performanceB = { NumberOfWins = 51; NumberOfLosses = 43 }
let performanceC = { NumberOfWins = 44; NumberOfLosses = 26 }
let performanceD = { NumberOfWins = 56; NumberOfLosses = 39 }
let performanceE = { NumberOfWins = 40; NumberOfLosses = 25 }

let teamAlpha = { TeamName = "Golden State Warriors"; HeadCoach = coachA; Performance = performanceA }
let teamBeta = { TeamName = "Chicago Bulls"; HeadCoach = coachB; Performance = performanceB }
let teamGamma = { TeamName = "Boston Celtics"; HeadCoach = coachC; Performance = performanceC }
let teamDelta = { TeamName = "Los Angeles Lakers"; HeadCoach = coachD; Performance = performanceD }
let teamEpsilon = { TeamName = "Toronto Raptors"; HeadCoach = coachE; Performance = performanceE }

let basketballTeams = [teamAlpha; teamBeta; teamGamma; teamDelta; teamEpsilon]

basketballTeams |> List.iter (fun team -> 
    printfn "Team Name: %s, Head Coach: %s, Wins: %d, Losses: %d" 
        team.TeamName team.HeadCoach.Name team.Performance.NumberOfWins team.Performance.NumberOfLosses)

let isTeamSuccessful team =
    team.Performance.NumberOfWins > team.Performance.NumberOfLosses

let successfulBasketballTeams = basketballTeams |> List.filter isTeamSuccessful

successfulBasketballTeams |> List.iter (fun team ->
    printfn "Successful Team: %s, Head Coach: %s, Wins: %d, Losses: %d" 
        team.TeamName team.HeadCoach.Name team.Performance.NumberOfWins team.Performance.NumberOfLosses)


let calculateSuccessPercentage team =
    float team.Performance.NumberOfWins / float (team.Performance.NumberOfWins + team.Performance.NumberOfLosses) * 100.0


let teamSuccessPercentages = basketballTeams |> List.map calculateSuccessPercentage

teamSuccessPercentages |> List.iter (fun percentage -> 
    printfn "Team Success Percentage: %.2f%%" percentage)
