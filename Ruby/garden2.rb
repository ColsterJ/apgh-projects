
keep_running = true

while keep_running
    puts "Enter length of garden box (or 'q' to quit): "
    length = gets.chomp
    if length == "q"
        keep_running = false
        next
    end
    length = length.to_i

    puts "Enter width of garden box: "
    width = gets.to_i

    area = length * width
    puts "The area is #{area}"
    perimeter = 2 * length + 2 * width
    puts "The perimeter is #{perimeter}"

    puts "What crop would you like to see?"
    puts "  Type 'z' for carrots."
    puts "  Type 'x' for corn."
    puts "  Type 'c' for beets."
    puts "  Type 'a' to stop asking.\n"
    
    keep_asking = true
    loop do
        input = gets.chomp.downcase
        case input
        when "z"
            puts "You could grow #{area * 16 / 16} carrot crops."
        when "x"
            puts "You could grow #{area * 3 / 16} corn crops."
        when "c"
            puts "You could grow #{area * 9 / 16} beet crops."
        when "a"
            keep_asking = false;
        else
            puts "Invalid input! Your options are z for carrots, x for corn, or c for beets.\nType 'a' to stop asking.\n"
        end
    break if !keep_asking
    end
    puts "\n"
end