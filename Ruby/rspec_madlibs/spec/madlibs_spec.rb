require 'madlibs'

RSpec.describe "madlibs works" do
    before(:all) do 
        @mad = MadLib.new 
    end

    it "lazy dog check" do
        @mad.process_template("The quick brown {noun} jumped over the {adjective} {noun}.")
        result = @mad.replace(["spaceship", "unbelievable", "fish"])
        expect(result).to eql("The quick brown spaceship jumped over the unbelievable fish.")
    end

    it "checks when identical prompts are repeated" do
        @mad.process_template("The {adjective} {adjective} {noun} jumped over the {adjective} {noun}.")
        result = @mad.replace(["smashing", "british af", "aubergine", "whiffy", "aluminium"])
        expect(result).to eql("The smashing british af aubergine jumped over the whiffy aluminium.")
    end
    
    it "fills the prompts array correctly" do
        @mad.process_template("Have you gone to {verb} the {royalty} for a {unit of measurement} of {beverage}?")
        result = @mad.get_prompts()
        expect(result).to eql(["{verb}", "{royalty}", "{unit of measurement}", "{beverage}"])
    end

    it "puts words from the array into output string" do
        @mad.process_template("The EU and U.K. agreed a new {European Thing} deal Thursday — but plenty of {adjective} hurdles remain before Britain exits the bloc. Word of a(n) {noun} came as EU leaders were en route to {place} for a crucial European Council summit. {Plural noun (capitalized)} have worked {adverb} in recent days hoping to clinch a new divorce decree before Thursday's summit, and it seems they have met that {noun} just under the wire.")
        result = @mad.replace(["gov'natorial", "dainty", "hotdog", "Piccadilly Circus", "Buddies", "humorously", "cricket"])
        expect(result).to eql("The EU and U.K. agreed a new gov'natorial deal Thursday — but plenty of dainty hurdles remain before Britain exits the bloc. Word of a(n) hotdog came as EU leaders were en route to Piccadilly Circus for a crucial European Council summit. Buddies have worked humorously in recent days hoping to clinch a new divorce decree before Thursday's summit, and it seems they have met that cricket just under the wire.")  
    end
end 
