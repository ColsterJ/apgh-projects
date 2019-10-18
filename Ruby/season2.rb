puts "What month were you born in? (1-12):"
month = gets.downcase
month_val = 1

if month.include? "jan"
    month_val = 1
elsif month.include? "feb"
    month_val = 2
elsif month.include? "mar"
    month_val = 3
elsif month.include? "apr"
    month_val = 4
elsif month.include? "may"
    month_val = 5
elsif month.include? "jun"
    month_val = 6
elsif month.include? "jul"
    month_val = 7
elsif month.include? "aug"
    month_val = 8
elsif month.include? "sep"
    month_val = 9
elsif month.include? "oct"
    month_val = 10
elsif month.include? "nov"
    month_val = 11
elsif month.include? "dec"
    month_val = 12
elsif (1..12) === month.to_i
    month_val = month.to_i
else
    puts "Invalid month!"
    exit
end

case month_val
when 12, 1, 2
    season = "Winter"
when 3, 4, 5
    season = "Spring"
when 6, 7, 8
    season = "Summer"
when 9, 10, 11
    season = "Fall"
end

puts "You were born in the season of #{season}"