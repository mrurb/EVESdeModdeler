﻿ALTER TABLE agtagents ADD FOREIGN KEY (divisionID) REFERENCES crpnpcdivisions(divisionID);
ALTER TABLE agtagents ADD FOREIGN KEY (corporationID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE agtagents ADD FOREIGN KEY (locationID) REFERENCES mapdenormalize(itemID);
ALTER TABLE agtagents ADD FOREIGN KEY (agentTypeID) REFERENCES agtagenttypes(agentTypeID);
ALTER TABLE agtresearchagents ADD FOREIGN KEY (agentID) REFERENCES agtagents(agentID);
ALTER TABLE agtresearchagents ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE certcerts ADD FOREIGN KEY (groupID) REFERENCES invgroups(groupID);
ALTER TABLE certmasteries ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE certmasteries ADD FOREIGN KEY (certID) REFERENCES certcerts(certID);
ALTER TABLE certskills ADD FOREIGN KEY (certID) REFERENCES certcerts(certID);
ALTER TABLE certskills ADD FOREIGN KEY (skillID) REFERENCES invtypes(typeID);
ALTER TABLE chrancestries ADD FOREIGN KEY (bloodlineID) REFERENCES chrbloodlines(bloodlineID);
ALTER TABLE chrancestries ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE chrattributes ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE chrbloodlines ADD FOREIGN KEY (raceID) REFERENCES chrraces(raceID);
ALTER TABLE chrbloodlines ADD FOREIGN KEY (shipTypeID) REFERENCES invtypes(typeID);
ALTER TABLE chrbloodlines ADD FOREIGN KEY (corporationID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE chrbloodlines ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE chrfactions ADD FOREIGN KEY (solarSystemID) REFERENCES mapsolarsystems(solarSystemID);
ALTER TABLE chrfactions ADD FOREIGN KEY (corporationID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE chrfactions ADD FOREIGN KEY (militiaCorporationID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE chrfactions ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE chrraces ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE crpnpccorporationdivisions ADD FOREIGN KEY (corporationID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE crpnpccorporationdivisions ADD FOREIGN KEY (divisionID) REFERENCES crpnpcdivisions(divisionID);
ALTER TABLE crpnpccorporationresearchfields ADD FOREIGN KEY (skillID) REFERENCES invtypes(typeID);
ALTER TABLE crpnpccorporationresearchfields ADD FOREIGN KEY (corporationID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE crpnpccorporations ADD FOREIGN KEY (solarSystemID) REFERENCES mapsolarsystems(solarSystemID);
ALTER TABLE crpnpccorporations ADD FOREIGN KEY (friendID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE crpnpccorporations ADD FOREIGN KEY (enemyID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE crpnpccorporations ADD FOREIGN KEY (factionID) REFERENCES chrfactions(factionID);
ALTER TABLE crpnpccorporations ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE crpnpccorporationtrades ADD FOREIGN KEY (corporationID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE crpnpccorporationtrades ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE dgmattributetypes ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE dgmattributetypes ADD FOREIGN KEY (unitID) REFERENCES eveunits(unitID);
ALTER TABLE dgmattributetypes ADD FOREIGN KEY (categoryID) REFERENCES dgmattributecategories(categoryID);
ALTER TABLE dgmeffects ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE dgmeffects ADD FOREIGN KEY (durationAttributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmeffects ADD FOREIGN KEY (trackingSpeedAttributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmeffects ADD FOREIGN KEY (dischargeAttributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmeffects ADD FOREIGN KEY (rangeAttributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmeffects ADD FOREIGN KEY (falloffAttributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmeffects ADD FOREIGN KEY (npcUsageChanceAttributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmeffects ADD FOREIGN KEY (npcActivationChanceAttributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmeffects ADD FOREIGN KEY (fittingUsageChanceAttributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmexpressions ADD FOREIGN KEY (expressionTypeID) REFERENCES invtypes(typeID);
ALTER TABLE dgmexpressions ADD FOREIGN KEY (expressionGroupID) REFERENCES invgroups(groupID);
ALTER TABLE dgmexpressions ADD FOREIGN KEY (expressionAttributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmtypeattributes ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE dgmtypeattributes ADD FOREIGN KEY (attributeID) REFERENCES dgmattributetypes(attributeID);
ALTER TABLE dgmtypeeffects ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE dgmtypeeffects ADD FOREIGN KEY (effectID) REFERENCES dgmeffects(effectID);
ALTER TABLE industryactivity ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivity ADD FOREIGN KEY (activityID) REFERENCES ramactivities(activityID);
ALTER TABLE industryactivitymaterials ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivitymaterials ADD FOREIGN KEY (activityID) REFERENCES ramactivities(activityID);
ALTER TABLE industryactivitymaterials ADD FOREIGN KEY (materialTypeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivityprobabilities ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivityprobabilities ADD FOREIGN KEY (activityID) REFERENCES ramactivities(activityID);
ALTER TABLE industryactivityprobabilities ADD FOREIGN KEY (productTypeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivityproducts ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivityproducts ADD FOREIGN KEY (activityID) REFERENCES ramactivities(activityID);
ALTER TABLE industryactivityproducts ADD FOREIGN KEY (productTypeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivityraces ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivityraces ADD FOREIGN KEY (activityID) REFERENCES ramactivities(activityID);
ALTER TABLE industryactivityraces ADD FOREIGN KEY (productTypeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivityraces ADD FOREIGN KEY (raceID) REFERENCES chrraces(raceID);
ALTER TABLE industryactivityskills ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE industryactivityskills ADD FOREIGN KEY (activityID) REFERENCES ramactivities(activityID);
ALTER TABLE industryactivityskills ADD FOREIGN KEY (skillID) REFERENCES invtypes(typeID);
ALTER TABLE industryblueprints ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE invcategories ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE invcontrabandtypes ADD FOREIGN KEY (factionID) REFERENCES chrfactions(factionID);
ALTER TABLE invcontrabandtypes ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE invcontroltowerresources ADD FOREIGN KEY (controlTowerTypeID) REFERENCES invtypes(typeID);
ALTER TABLE invcontroltowerresources ADD FOREIGN KEY (resourceTypeID) REFERENCES invtypes(typeID);
ALTER TABLE invcontroltowerresources ADD FOREIGN KEY (factionID) REFERENCES chrfactions(factionID);
ALTER TABLE invgroups ADD FOREIGN KEY (categoryID) REFERENCES invcategories(categoryID);
ALTER TABLE invgroups ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE invitems ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE invitems ADD FOREIGN KEY (ownerID) REFERENCES invitems(itemID);
ALTER TABLE invitems ADD FOREIGN KEY (locationID) REFERENCES mapdenormalize(itemID);
ALTER TABLE invitems ADD FOREIGN KEY (flagID) REFERENCES invflags(flagID);
ALTER TABLE invmarketgroups ADD FOREIGN KEY (parentGroupID) REFERENCES invmarketgroups(marketGroupID);
ALTER TABLE invmarketgroups ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE invmetagroups ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE invmetatypes ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE invmetatypes ADD FOREIGN KEY (parentTypeID) REFERENCES invtypes(typeID);
ALTER TABLE invmetatypes ADD FOREIGN KEY (metaGroupID) REFERENCES invmetagroups(metaGroupID);
ALTER TABLE invnames ADD FOREIGN KEY (itemID) REFERENCES invitems(itemID);
ALTER TABLE invpositions ADD FOREIGN KEY (itemID) REFERENCES invitems(itemID);
ALTER TABLE invtraits ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE invtraits ADD FOREIGN KEY (skillID) REFERENCES invtypes(typeID);
ALTER TABLE invtraits ADD FOREIGN KEY (unitID) REFERENCES eveunits(unitID);
ALTER TABLE invtypematerials ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE invtypematerials ADD FOREIGN KEY (materialTypeID) REFERENCES invtypes(typeID);
ALTER TABLE invtypereactions ADD FOREIGN KEY (reactionTypeID) REFERENCES invtypes(typeID);
ALTER TABLE invtypereactions ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE invtypes ADD FOREIGN KEY (groupID) REFERENCES invgroups(groupID);
ALTER TABLE invtypes ADD FOREIGN KEY (raceID) REFERENCES chrraces(raceID);
ALTER TABLE invtypes ADD FOREIGN KEY (marketGroupID) REFERENCES invmarketgroups(marketGroupID);
ALTER TABLE invtypes ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE invtypes ADD FOREIGN KEY (graphicID) REFERENCES evegraphics(graphicID);
ALTER TABLE invuniquenames ADD FOREIGN KEY (itemID) REFERENCES invitems(itemID);
ALTER TABLE invuniquenames ADD FOREIGN KEY (groupID) REFERENCES invgroups(groupID);
ALTER TABLE invvolumes ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE mapcelestialstatistics ADD FOREIGN KEY (celestialID) REFERENCES invitems(itemID);
ALTER TABLE mapconstellationjumps ADD FOREIGN KEY (fromRegionID) REFERENCES mapregions(regionID);
ALTER TABLE mapconstellationjumps ADD FOREIGN KEY (fromConstellationID) REFERENCES mapconstellations(constellationID);
ALTER TABLE mapconstellationjumps ADD FOREIGN KEY (toConstellationID) REFERENCES mapconstellations(constellationID);
ALTER TABLE mapconstellationjumps ADD FOREIGN KEY (toRegionID) REFERENCES mapregions(regionID);
ALTER TABLE mapconstellations ADD FOREIGN KEY (regionID) REFERENCES mapregions(regionID);
ALTER TABLE mapconstellations ADD FOREIGN KEY (constellationID) REFERENCES mapconstellations(constellationID);
ALTER TABLE mapconstellations ADD FOREIGN KEY (factionID) REFERENCES chrfactions(factionID);
ALTER TABLE mapdenormalize ADD FOREIGN KEY (itemID) REFERENCES invitems(itemID);
ALTER TABLE mapdenormalize ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE mapdenormalize ADD FOREIGN KEY (groupID) REFERENCES invgroups(groupID);
ALTER TABLE mapdenormalize ADD FOREIGN KEY (solarSystemID) REFERENCES mapsolarsystems(solarSystemID);
ALTER TABLE mapdenormalize ADD FOREIGN KEY (constellationID) REFERENCES mapconstellations(constellationID);
ALTER TABLE mapdenormalize ADD FOREIGN KEY (regionID) REFERENCES mapregions(regionID);
ALTER TABLE mapdenormalize ADD FOREIGN KEY (orbitID) REFERENCES mapcelestialstatistics(celestialID);
ALTER TABLE mapjumps ADD FOREIGN KEY (stargateID) REFERENCES mapdenormalize(itemID);
ALTER TABLE mapjumps ADD FOREIGN KEY (destinationID) REFERENCES mapdenormalize(itemID);
ALTER TABLE maplandmarks ADD FOREIGN KEY (locationID) REFERENCES mapdenormalize(itemID);
ALTER TABLE maplandmarks ADD FOREIGN KEY (iconID) REFERENCES eveicons(iconID);
ALTER TABLE maplocationscenes ADD FOREIGN KEY (locationID) REFERENCES mapdenormalize(itemID);
ALTER TABLE maplocationscenes ADD FOREIGN KEY (graphicID) REFERENCES evegraphics(graphicID);
ALTER TABLE maplocationwormholeclasses ADD FOREIGN KEY (locationID) REFERENCES mapdenormalize(itemID);
ALTER TABLE mapregionjumps ADD FOREIGN KEY (fromRegionID) REFERENCES mapregions(regionID);
ALTER TABLE mapregionjumps ADD FOREIGN KEY (toRegionID) REFERENCES mapregions(regionID);
ALTER TABLE mapregions ADD FOREIGN KEY (factionID) REFERENCES chrfactions(factionID);
ALTER TABLE mapsolarsystemjumps ADD FOREIGN KEY (fromRegionID) REFERENCES mapregions(regionID);
ALTER TABLE mapsolarsystemjumps ADD FOREIGN KEY (fromConstellationID) REFERENCES mapconstellations(constellationID);
ALTER TABLE mapsolarsystemjumps ADD FOREIGN KEY (fromSolarSystemID) REFERENCES mapsolarsystems(solarSystemID);
ALTER TABLE mapsolarsystemjumps ADD FOREIGN KEY (toSolarSystemID) REFERENCES mapsolarsystems(solarSystemID);
ALTER TABLE mapsolarsystemjumps ADD FOREIGN KEY (toConstellationID) REFERENCES mapconstellations(constellationID);
ALTER TABLE mapsolarsystemjumps ADD FOREIGN KEY (toRegionID) REFERENCES mapregions(regionID);
ALTER TABLE mapsolarsystems ADD FOREIGN KEY (regionID) REFERENCES mapregions(regionID);
ALTER TABLE mapsolarsystems ADD FOREIGN KEY (constellationID) REFERENCES mapconstellations(constellationID);
ALTER TABLE mapsolarsystems ADD FOREIGN KEY (factionID) REFERENCES chrfactions(factionID);
ALTER TABLE mapsolarsystems ADD FOREIGN KEY (sunTypeID) REFERENCES invtypes(typeID);
ALTER TABLE planetschematicspinmap ADD FOREIGN KEY (schematicID) REFERENCES planetschematics(schematicID);
ALTER TABLE planetschematicspinmap ADD FOREIGN KEY (pinTypeID) REFERENCES invtypes(typeID);
ALTER TABLE planetschematicstypemap ADD FOREIGN KEY (schematicID) REFERENCES planetschematics(schematicID);
ALTER TABLE planetschematicstypemap ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE ramassemblylinestations ADD FOREIGN KEY (stationID) REFERENCES stastations(stationID);
ALTER TABLE ramassemblylinestations ADD FOREIGN KEY (assemblyLineTypeID) REFERENCES ramassemblylinetypes(assemblyLineTypeID);
ALTER TABLE ramassemblylinestations ADD FOREIGN KEY (stationTypeID) REFERENCES stastationtypes(stationTypeID);
ALTER TABLE ramassemblylinestations ADD FOREIGN KEY (ownerID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE ramassemblylinestations ADD FOREIGN KEY (solarSystemID) REFERENCES mapsolarsystems(solarSystemID);
ALTER TABLE ramassemblylinestations ADD FOREIGN KEY (regionID) REFERENCES mapregions(regionID);
ALTER TABLE ramassemblylinetypedetailpercategory ADD FOREIGN KEY (assemblyLineTypeID) REFERENCES ramassemblylinetypes(assemblyLineTypeID);
ALTER TABLE ramassemblylinetypedetailpercategory ADD FOREIGN KEY (categoryID) REFERENCES invgroups(categoryID);
ALTER TABLE ramassemblylinetypedetailpergroup ADD FOREIGN KEY (assemblyLineTypeID) REFERENCES ramassemblylinetypes(assemblyLineTypeID);
ALTER TABLE ramassemblylinetypedetailpergroup ADD FOREIGN KEY (groupID) REFERENCES invgroups(groupID);
ALTER TABLE ramassemblylinetypes ADD FOREIGN KEY (activityID) REFERENCES ramactivities(activityID);
ALTER TABLE raminstallationtypecontents ADD FOREIGN KEY (installationTypeID) REFERENCES invtypes(typeID);
ALTER TABLE raminstallationtypecontents ADD FOREIGN KEY (assemblyLineTypeID) REFERENCES ramassemblylinetypes(assemblyLineTypeID);
ALTER TABLE skinlicense ADD FOREIGN KEY (licenseTypeID) REFERENCES invtypes(typeID);
ALTER TABLE skinlicense ADD FOREIGN KEY (skinID) REFERENCES skins(skinID);
ALTER TABLE skins ADD FOREIGN KEY (skinMaterialID) REFERENCES skinmaterials(skinMaterialID);
ALTER TABLE skinship ADD FOREIGN KEY (skinID) REFERENCES skins(skinID);
ALTER TABLE skinship ADD FOREIGN KEY (typeID) REFERENCES invtypes(typeID);
ALTER TABLE staoperations ADD FOREIGN KEY (activityID) REFERENCES crpactivities(activityID);
ALTER TABLE staoperations ADD FOREIGN KEY (caldariStationTypeID) REFERENCES stastationtypes(stationTypeID);
ALTER TABLE staoperations ADD FOREIGN KEY (minmatarStationTypeID) REFERENCES stastationtypes(stationTypeID);
ALTER TABLE staoperations ADD FOREIGN KEY (amarrStationTypeID) REFERENCES stastationtypes(stationTypeID);
ALTER TABLE staoperations ADD FOREIGN KEY (gallenteStationTypeID) REFERENCES stastationtypes(stationTypeID);
ALTER TABLE staoperations ADD FOREIGN KEY (joveStationTypeID) REFERENCES stastationtypes(stationTypeID);
ALTER TABLE staoperationservices ADD FOREIGN KEY (operationID) REFERENCES staoperations(operationID);
ALTER TABLE staoperationservices ADD FOREIGN KEY (serviceID) REFERENCES staservices(serviceID);
ALTER TABLE stastations ADD FOREIGN KEY (operationID) REFERENCES staoperations(operationID);
ALTER TABLE stastations ADD FOREIGN KEY (stationTypeID) REFERENCES stastationtypes(stationTypeID);
ALTER TABLE stastations ADD FOREIGN KEY (corporationID) REFERENCES crpnpccorporations(corporationID);
ALTER TABLE stastations ADD FOREIGN KEY (solarSystemID) REFERENCES mapsolarsystems(solarSystemID);
ALTER TABLE stastations ADD FOREIGN KEY (constellationID) REFERENCES mapconstellations(constellationID);
ALTER TABLE stastations ADD FOREIGN KEY (regionID) REFERENCES mapregions(regionID);
ALTER TABLE stastationtypes ADD FOREIGN KEY (operationID) REFERENCES staoperations(operationID);
ALTER TABLE warcombatzones ADD FOREIGN KEY (factionID) REFERENCES chrfactions(factionID);
ALTER TABLE warcombatzones ADD FOREIGN KEY (centerSystemID) REFERENCES mapsolarsystems(solarSystemID);
ALTER TABLE warcombatzonesystems ADD FOREIGN KEY (solarSystemID) REFERENCES mapsolarsystems(solarSystemID);
ALTER TABLE warcombatzonesystems ADD FOREIGN KEY (combatZoneID) REFERENCES warcombatzones(combatZoneID);