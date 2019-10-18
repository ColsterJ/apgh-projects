string = "You are so {adjective} to {person}, and {person} and {European Thing} agrees"
prompts = string.scan(/{[\w ]+}/)      # was trying to use string.matches() which is just not right for what i'm doing
puts prompts


# def match_first(source,match)

# end

/{[\w ]+}/