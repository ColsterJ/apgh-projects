/loop thru and compare each element to the one right after it
if number one is greater than number two, switcheroo
don't sort past the last element
once it goes thru without changes, stop/

class Sorter
    # Quicksort
    def sort(arrayofnumbers)
        if arrayofnumbers.length <= 1
         return arrayofnumbers
        else 
             pivot = arrayofnumbers.sample
             arrayofnumbers.delete_at(arrayofnumbers.index(pivot))
             less = Array.new
             greater = []
 
             arrayofnumbers.each do |x|
                 if x <= pivot
                     less << x
                 else
                     greater << x
                 end
             end
 
             sorted_array = []
             sorted_array << self.sort(less)
             sorted_array << pivot
             sorted_array << self.sort(greater)
 
             return sorted_array.flatten!
         end
     end
    # def sort(arrayofnumbers)
    #     # Bubble Sort
    #     keepgoing = true
    #     while (keepgoing)
    #         keepgoing = false

    #         (0..(arrayofnumbers.length - 2)).each do |index|
    #             if arrayofnumbers[index] > arrayofnumbers[index + 1]
    #                 temp = arrayofnumbers[index]
    #                 arrayofnumbers[index] = arrayofnumbers[index + 1]
    #                 arrayofnumbers[index + 1] = temp

    #                 keepgoing = true
    #             end
    #         end
    #     end

    #     return arrayofnumbers
    # end
end

# # loop through and determine if number after number is less than or greater and rearrange accordingly
# class Sorter
#     def sort(arrayofnumbers)
#         arraysize = arrayofnumbers.length

#         keep_going = true
#         while (keep_going)
#             keep_going = false

#                 (0..(arraysize-2)).each do |index|
#                     if arrayofnumbers[index] > arrayofnumbers[index + 1]
#                         temp = arrayofnumbers[index]
#                         arrayofnumbers[index] = arrayofnumbers[index + 1]
#                         arrayofnumbers[index + 1] = temp

#                         keep_going = true
#                     end
#                 end
#             end
#             return arrayofnumbers
#         end      
#     end
