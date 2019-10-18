keep_running = true
counter = 0
while keep_running
    counter = counter + 1

    if counter == 10
        puts "\n\nThis is the tenth time, so it's your last chance"
        keep_running = false
    end

    puts "What month were you born in? Type a month name or number, or type 'quit' to quit:"
    month = gets.chomp.downcase

    if month == "quit"
        puts "Really quit? (y/n)"
        input = gets.downcase
        if input.include? "y"
            keep_running = false
        end
        next
    else
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
    end

end