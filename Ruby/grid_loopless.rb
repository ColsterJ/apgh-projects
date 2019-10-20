# As an exercise with map and reduce, trying out printing a multidimensional array
# Inspired by http://flats.github.io/blog/2015/12/02/getting-to-know-rubys-map-and-reduce/

grid = Array.new(5) {Array.new(5) {0}}
grid[0][4] = 1
grid[2][2] = 2
grid[1][3] = 5
grid_height = grid.length
grid_width = grid[0].length

puts "Grid printed with each loops"
grid.each do |row|
    row.each do |cell|
        print "#{cell} "
    end
    print "\n"
end

puts "\nGrid printed with map" # This looks an awful lot like "each", and you could do do/end instead to make it even more like that
grid.map { |row|
    row.map { |cell|
        print "#{cell} "
    }
    print "\n"
}

puts "\nGrid using reduce - reduce(){} syntax"
print grid.reduce("") { |s, row|
    "#{s}#{
        row.reduce("") {|s, cell| "#{s}#{cell.to_s} "}
    }\n"
}

# Grid using reduce() syntax without {}? I can't figure it out








# Grosser each style to sate my curiosity (even more like 'for' loop)
# (0..grid_height-1).each do |row|
#     (0..grid_width-1).each do |cell|
#         print "#{grid[row][cell]} "
#     end
#     print "\n"
# end