require "sorter"

RSpec.describe Sorter do
    /test one number
       sort two numbers
       sort several numbers
       sort(alphabetize) two letters 
       sort several letters
       /
  
    it "test 1 number" do
      sorter = Sorter.new
      answer = sorter.sort([1])
      expect(answer).to eql [1]
    end

  
    it "test several numbers" do
      sorter = Sorter.new
      answer = sorter.sort([1, 50, 4, 3, 5])
      expect(answer).to eql [1, 3, 4, 5, 50]
    end
  end
  