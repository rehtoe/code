require 'occupado.rb'

class Food < OcupaTile

  def initialize()
      @isSolid = true
      @isEdible = true
      @isHealthy = true
      @canKill = false
      @isEmpty = false
  end
  
end
