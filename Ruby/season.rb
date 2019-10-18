puts "What month were you born in? (1-12):"
month = gets.to_i

case month
when 12, 1, 2
    season = "Winter"
when 3, 4, 5
    season = "Spring"
when 6, 7, 8
    season = "Summer"
when 9, 10, 11
    season = "Fall"
else
    puts "Invalid input - Month must be entered as a number 1-12!"
    exit
end

puts "You were born in the season of #{season}"