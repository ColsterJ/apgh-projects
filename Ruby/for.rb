# In Ruby, don't generally do the 'counting' type loop of taking i from 1 to 10
# Instead, we say do this one time for each thing in a collection
# for loops don't have a conditional in Ruby the way they do in C#
#
# [1,2,3,4,5] is an array
# 1..3 is a range
# 1..3 can be used like an array

# for i in [1,2,3,4,5]
#     puts i
# end

("a".."e").each do |i|
    puts i
end

firstTime = true
(1..10).each do |i|
    puts i
    if i == 5 && firstTime
        firstTime = false
        redo
    end
end


# can't do ranges with floats! not discrete like integers or letters