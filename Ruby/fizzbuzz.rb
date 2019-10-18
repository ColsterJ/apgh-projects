# # FIZZBUZZ

# (1..15).each do |x|
#     s = ""
#     if x % 3 == 0
#         s = s + "fizz"
#     end
#     if x % 5 == 0
#         s = s + "buzz"
#     end
#     if s != ""
#         puts s
#     else
#         puts "#{x}"
#     end
# end

# FIZZBUZZ BY 2s
# Thanks Jesse and Patrick for step()
(1..15).step(2).each do |x|
    s = ""
    if x % 3 == 0
        s = s + "fizz"
    end
    if x % 5 == 0
        s = s + "buzz"
    end
    if s != ""
        puts s
    else
        puts "#{x}"
    end
end

# # BACKWARDS FIZZBUZZ
# can also use (1..15).reverse_each

# 15.downto(1) do |x|
#     s = ""
#     if x % 3 == 0
#         s = s + "fizz"
#     end
#     if x % 5 == 0
#         s = s + "buzz"
#     end
#     if s != ""
#         puts s
#     else
#         puts "#{x}"
#     end
# end