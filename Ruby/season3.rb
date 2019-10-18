puts "What month were you born in? (1-12):"
month = gets.downcase
month_val = 1

if (month.include? "dec") || (month.include? "jan") || (month.include? "feb") || (month.to_i.between?(1,2)) || (month.to_i == 12)
    season = "Winter"
elsif (month.include? "mar") || (month.include? "apr") || (month.include? "may") || (month.to_i.between?(3,5))
    season = "Spring"
elsif (month.include? "jun") || (month.include? "jul") || (month.include? "aug") || (month.to_i.between?(6,8))
    season = "Summer"
elsif (month.include? "sep") || (month.include? "oct") || (month.include? "nov") || (month.to_i.between?(9,11))
    season = "Fall"
else
    puts "Invalid month!"
    exit
end

puts "You were born in the season of #{season}"