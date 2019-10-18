
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

    puts "You could grow #{area * 16 / 16} carrot crops."
    puts "You could grow #{area * 3 / 16} corn crops."
    puts "You could grow #{area * 9 / 16} beet crops.\n\n"
end