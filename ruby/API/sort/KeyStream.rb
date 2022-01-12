
class KeyStream

  attr_reader :run, :inputs, :exitkey

  def initialize(exitkey)
    @exitkey = exitkey[0]
    @run = false;
    @inputs = [ ]
    end

  def run
    run = true
    phinp = ""
    while run == true do
      phnip = gets.chomp[0,1]
      @inputs.shift(@phnip)
      if(@inputs[0] == @exitkey)
        run = false
        end
      end

    end

end
