# Find indexes of elements cumulatively and remove from 2D-list

''' Find and add indexes to a list
numOfUniqueValsForCatCols.append(numOfUniqueValsForCatCols[-1] + numOfUniqueVals)

''' Remove elements that is in specified positions '''
tmpX = [j for i, j in enumerate(self.X) if i not in [0, numOfUniqueValsForCatCols[i] ] ]
