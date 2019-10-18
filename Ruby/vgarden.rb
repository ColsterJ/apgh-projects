
puts "What is the length of your garden box?"
length = gets.chomp.to_i
puts "What is the width of your garden box?"
width = gets.chomp.to_i
area = length * width
perimeter = (length * 2) + (width * 2)
puts "The area of your garden box is " + area.to_s + " \nand the perimeter of your garden box is " + perimeter.to_s

possible_carrots = area
possible_corn = area * 3 / 16
possible_beets = area * 9 / 16

this = (0..(length-1))
that = (0..(width-1))
puts this 
puts that
this.each do |i|

    that.each do |this|
    
        print "[ ]"
    
    print " "
    end
puts " "
end
puts "What would you like to plant?\n carrots:  V \n corn: ¥ \n or beets: ø "
planted = gets.chomp
while possible_beets > 0 && possible_corn > 0 && possible_carrots > 0

    if planted == "carrots"
        puts "You can plant #{possible_carrots} carrots"
        possible_carrots -= 1
        this = (0..(length -1))
        that = (0..(width -1))
        this.each do |i|

            that.each do |this|
                
                print " <%"
                possible_carrots -= 1
                
            print " "
            end
        puts " "
        end
        
    elsif planted == "corn"
        puts "You can plant #{possible_corn} corn "
        this = (0..length)
        that = (0..width)
        possible_corn -= 1
        this.each do |i|

            that.each do |this|
                
                print "¥"
                possible_corn -= 1
                
            print " "
            end
        puts " "
        end
    elsif planted == "beets"
        puts "You can plant #{possible_beets} beets"
        rows = (0..length)      # this
        cols = (0..width)       # that
        step = area.to_f / possible_beets
        step = step.ceil
        #still_planting += 1
        beet_position = 0
        while possible_beets > 0
            rows.each do
                # TODO checkerboard pattern
                cols.each do
                    if possible_beets >= 1 && (beet_position % step == 0)
                        print " ø%"
                        possible_beets -= 1
                    else
                        print "[ ]"
                    end
                    beet_position += 1
                    # puts "beet position % step is #{beet_position % step}"
                print " "
                end
            puts " "
            end
        end
    else
        puts "We don't know that plant!"
        still_planting += 1
    end
end

puts "You can plant #{possible_carrots} carrots #{possible_corn} corn and #{possible_beets} beets"
