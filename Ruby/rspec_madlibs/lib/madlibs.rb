class MadLib
    def initialize 
        @mad_words = []
        @mad_prompts = []
        @template = ""
    end

    def replace arr
        @mad_words = arr
        output = @template
        (0..@mad_prompts.length-1).each do |index|
            output = output.sub(@mad_prompts[index], @mad_words[index])
        end
        return output
    end

    def process_template text
        @template = text
        find_prompts
    end

    def find_prompts #hard part! BREXIT HARD
        # go through template and find all the {prompts}
        # put those {prompts} into @mad_prompts

        # @mad_prompts = @template.scan(/{[\w ]+}/)   # Allows for words and spaces, but not common punctuation
        @mad_prompts = @template.scan(/{[\w _\-()!?.,:;'"\[\]\/\\]+}/)         # Thanks Rubular
            # Should allow for words, spaces, and most common punctuation
        return @mad_prompts
    end

    def get_prompts
        return @mad_prompts
    end

    # def fill_words arr
    #     @mad_words = arr
    # end
end
