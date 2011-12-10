Imports System.IO

Public Class EasyItemMaker

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case CreationType.Text
            Case Is = String.Empty
                DataSet.Enabled = False
                CheckBox1.Enabled = False
                DataValues.Enabled = False
                CustDataValue.Enabled = False
                DataAdd.Enabled = False
            Case Is <> String.Empty
                DataSet.Enabled = True
                DataValues.Enabled = True
                CheckBox1.Enabled = True
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSet.SelectedIndexChanged
        If DataSet.Text = String.Empty Then
            DataValues.Enabled = False
            CheckBox1.Enabled = False
            CustDataValue.Enabled = False
            DataAdd.Enabled = False
        Else
            DataValues.Enabled = True
            CheckBox1.Enabled = True
        End If

        ChangeDataValues()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CustDataValue.Enabled = True
            DataValues.Text = String.Empty
            DataValues.Enabled = False
        Else
            CustDataValue.Enabled = False
            DataValues.Enabled = True
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataValues.SelectedIndexChanged
        If DataValues.Text = String.Empty And CustDataValue.Text = String.Empty Then
            DataAdd.Enabled = False
        Else
            DataAdd.Enabled = True
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreationType.SelectedIndexChanged
        If CreationType.Text = String.Empty Then
            DataSet.Enabled = False
            DataValues.Enabled = False
            CheckBox1.Enabled = False
            CustDataValue.Enabled = False
            DataAdd.Enabled = False
        Else
            DataSet.Enabled = True
        End If

        ChangeDataSets()
    End Sub

    Public Sub ChangeDataSets()
        'Programmatically change DataSet's items according to CreationType
        Select Case CreationType.Text
            Case Is = "Weapon"
                DataSet.Items.Clear()
                DataSet.Items.Add("Class")
                DataSet.Items.Add("SubClass")
                DataSet.Items.Add("Quality")
                DataSet.Items.Add("Flags")
                DataSet.Items.Add("FlagsExtra")
                DataSet.Items.Add("InventoryType")
                DataSet.Items.Add("AllowableClass")
                DataSet.Items.Add("AllowableRace")
                DataSet.Items.Add("Stat_Type1")
                DataSet.Items.Add("Stat_Type2")
                DataSet.Items.Add("Stat_Type3")
                DataSet.Items.Add("Stat_Type4")
                DataSet.Items.Add("Stat_Type5")
                DataSet.Items.Add("Stat_Type6")
                DataSet.Items.Add("Stat_Type7")
                DataSet.Items.Add("Stat_Type8")
                DataSet.Items.Add("Stat_Type9")
                DataSet.Items.Add("Stat_Type10")
                DataSet.Items.Add("DamageType")
                DataSet.Items.Add("Bonding")
                DataSet.Items.Add("Material")
                DataSet.Items.Add("Sheath")
                DataSet.Items.Add("SocketColor_1")
                DataSet.Items.Add("SocketColor_2")
                DataSet.Items.Add("SocketColor_3")
                DataSet.Items.Add("SocketBonus")
            Case Is = "Armor"
                DataSet.Items.Clear()
                DataSet.Items.Add("Class")
                DataSet.Items.Add("SubClass")
                DataSet.Items.Add("Quality")
                DataSet.Items.Add("Flags")
                DataSet.Items.Add("FlagsExtra")
                DataSet.Items.Add("InventoryType")
                DataSet.Items.Add("AllowableClass")
                DataSet.Items.Add("AllowableRace")
                DataSet.Items.Add("Stat_Type1")
                DataSet.Items.Add("Stat_Type2")
                DataSet.Items.Add("Stat_Type3")
                DataSet.Items.Add("Stat_Type4")
                DataSet.Items.Add("Stat_Type5")
                DataSet.Items.Add("Stat_Type6")
                DataSet.Items.Add("Stat_Type7")
                DataSet.Items.Add("Stat_Type8")
                DataSet.Items.Add("Stat_Type9")
                DataSet.Items.Add("Stat_Type10")
                DataSet.Items.Add("Bonding")
                DataSet.Items.Add("SocketColor_1")
                DataSet.Items.Add("SocketColor_2")
                DataSet.Items.Add("SocketColor_3")
                DataSet.Items.Add("SocketBonus")
            Case Is = "Bag"
                DataSet.Items.Clear()
                DataSet.Items.Add("Class")
                DataSet.Items.Add("SubClass")
                DataSet.Items.Add("Quality")
                DataSet.Items.Add("Flags")
                DataSet.Items.Add("FlagsExtra")
                DataSet.Items.Add("InventoryType")
                DataSet.Items.Add("AllowableClass")
                DataSet.Items.Add("AllowableRace")
                DataSet.Items.Add("Bonding")
                DataSet.Items.Add("BagFamily")
        End Select
    End Sub

    Public Sub ChangeDataValues()
        'Programmatically change DataValue's items according to both CreationType & DataSet
        Select Case CreationType.Text
            Case Is = "Weapon"
                Select Case DataSet.Text
                    Case Is = "Class"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Weapon")
                    Case Is = "SubClass"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Axe (1H)")
                        DataValues.Items.Add("Axe (2H)")
                        DataValues.Items.Add("Bow")
                        DataValues.Items.Add("Gun")
                        DataValues.Items.Add("Mace (1H)")
                        DataValues.Items.Add("Maxe (2H)")
                        DataValues.Items.Add("Polearm")
                        DataValues.Items.Add("Sword (1H)")
                        DataValues.Items.Add("Sword (2H)")
                        DataValues.Items.Add("Staff")
                        DataValues.Items.Add("Fist Weapon")
                        DataValues.Items.Add("Dagger")
                        DataValues.Items.Add("Thrown")
                        DataValues.Items.Add("Spear")
                        DataValues.Items.Add("Crossbow")
                        DataValues.Items.Add("Wand")
                        DataValues.Items.Add("Fishing Pole")
                    Case Is = "Quality"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Poor")
                        DataValues.Items.Add("Common")
                        DataValues.Items.Add("Uncommon")
                        DataValues.Items.Add("Rare")
                        DataValues.Items.Add("Epic")
                        DataValues.Items.Add("Legendary")
                        DataValues.Items.Add("Artifact")
                        DataValues.Items.Add("Bind to Account")
                    Case Is = "Flags"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("None (Default)")
                        DataValues.Items.Add("Soulbound")
                        DataValues.Items.Add("Heroic")
                        DataValues.Items.Add("Party Looted")
                        DataValues.Items.Add("Refundable")
                        DataValues.Items.Add("PvP Reward")
                        DataValues.Items.Add("Unique-Equipped")
                        DataValues.Items.Add("Throwable")
                        DataValues.Items.Add("Bind To Account")
                        DataValues.Items.Add("Bind on Pickup & Tradeable")
                    Case Is = "FlagsExtra"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Both Factions (Default)")
                        DataValues.Items.Add("Horde")
                        DataValues.Items.Add("Alliance")
                        DataValues.Items.Add("Uses ExtendedCost")
                        DataValues.Items.Add("Disable Need Roll")
                    Case Is = "InventoryType"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("One-Hand")
                        DataValues.Items.Add("Ranged")
                        DataValues.Items.Add("Two-Hand")
                        DataValues.Items.Add("Main-Hand")
                        DataValues.Items.Add("Off-Hand")
                        DataValues.Items.Add("Thrown")
                    Case Is = "AllowableClass"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("All Classes")
                        DataValues.Items.Add("Melee Classes")
                        DataValues.Items.Add("Offensive Caster Classes")
                        DataValues.Items.Add("Healer Classes")
                        DataValues.Items.Add("Plate Classes")
                        DataValues.Items.Add("Mail Classes")
                        DataValues.Items.Add("Leather Classes")
                        DataValues.Items.Add("Cloth Classes")
                        DataValues.Items.Add("Warrior")
                        DataValues.Items.Add("Paladin")
                        DataValues.Items.Add("Hunter")
                        DataValues.Items.Add("Rogue")
                        DataValues.Items.Add("Priest")
                        DataValues.Items.Add("Death Knight")
                        DataValues.Items.Add("Shaman")
                        DataValues.Items.Add("Mage")
                        DataValues.Items.Add("Warlock")
                        DataValues.Items.Add("Druid")
                    Case Is = "AllowableRace"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("All Races")
                        DataValues.Items.Add("Alliance Races")
                        DataValues.Items.Add("Horde Races")
                        DataValues.Items.Add("Burning Crusade Races")
                        DataValues.Items.Add("Cataclysm Races")
                        DataValues.Items.Add("Human")
                        DataValues.Items.Add("Orc")
                        DataValues.Items.Add("Dwarf")
                        DataValues.Items.Add("Night Elf")
                        DataValues.Items.Add("Undead")
                        DataValues.Items.Add("Tauren")
                        DataValues.Items.Add("Gnome")
                        DataValues.Items.Add("Troll")
                        DataValues.Items.Add("Goblin")
                        DataValues.Items.Add("Blood Elf")
                        DataValues.Items.Add("Draenei")
                    Case Is = "Stat_Type1"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type2"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type3"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type4"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type5"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type6"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type7"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type8"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type9"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type10"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "DamageType"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Physical")
                        DataValues.Items.Add("Holy")
                        DataValues.Items.Add("Fire")
                        DataValues.Items.Add("Nature")
                        DataValues.Items.Add("Frost")
                        DataValues.Items.Add("Shadow")
                        DataValues.Items.Add("Arcane")
                    Case Is = "Bonding"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("No Bounds")
                        DataValues.Items.Add("Binds on Pickup")
                        DataValues.Items.Add("Binds on Equip")
                    Case Is = "Material"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Undefined")
                        DataValues.Items.Add("Metal")
                        DataValues.Items.Add("Wood")
                    Case Is = "Sheath"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Two-Handed")
                        DataValues.Items.Add("Staff")
                        DataValues.Items.Add("One-Handed")
                        DataValues.Items.Add("Off-Hand")
                    Case Is = "SocketColor_1"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Red")
                        DataValues.Items.Add("Yellow")
                        DataValues.Items.Add("Blue")
                    Case Is = "SocketColor_2"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Red")
                        DataValues.Items.Add("Yellow")
                        DataValues.Items.Add("Blue")
                    Case Is = "SocketColor_3"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Red")
                        DataValues.Items.Add("Yellow")
                        DataValues.Items.Add("Blue")
                    Case Is = "SocketBonus"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("+8 Strength")
                        DataValues.Items.Add("+8 Agility")
                        DataValues.Items.Add("+12 Stamina")
                        DataValues.Items.Add("+8 Intellect")
                        DataValues.Items.Add("+9 Healing")
                        DataValues.Items.Add("+9 Spell Power")
                        DataValues.Items.Add("+16 Attack Power")
                End Select
            Case Is = "Armor"
                Select Case DataSet.Text
                    Case Is = "Class"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Armor")
                    Case Is = "SubClass"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Cloth")
                        DataValues.Items.Add("Leather")
                        DataValues.Items.Add("Mail")
                        DataValues.Items.Add("Plate")
                        DataValues.Items.Add("Shield")
                        DataValues.Items.Add("Libram")
                        DataValues.Items.Add("Idol")
                        DataValues.Items.Add("Totem")
                    Case Is = "Quality"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Poor")
                        DataValues.Items.Add("Common")
                        DataValues.Items.Add("Uncommon")
                        DataValues.Items.Add("Rare")
                        DataValues.Items.Add("Epic")
                        DataValues.Items.Add("Legendary")
                        DataValues.Items.Add("Artifact")
                        DataValues.Items.Add("Bind to Account")
                    Case Is = "Flags"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("None (Default)")
                        DataValues.Items.Add("Soulbound")
                        DataValues.Items.Add("Heroic")
                        DataValues.Items.Add("Totem")
                        DataValues.Items.Add("Party Looted")
                        DataValues.Items.Add("Refundable")
                        DataValues.Items.Add("PvP Reward")
                        DataValues.Items.Add("Unique-Equipped")
                        DataValues.Items.Add("Bind To Account")
                        DataValues.Items.Add("Bind on Pickup & Tradeable")
                    Case Is = "FlagsExtra"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Both Factions (Default)")
                        DataValues.Items.Add("Horde")
                        DataValues.Items.Add("Alliance")
                        DataValues.Items.Add("Uses ExtendedCost")
                        DataValues.Items.Add("Disable Need Roll")
                    Case Is = "InventoryType"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Head")
                        DataValues.Items.Add("Neck")
                        DataValues.Items.Add("Shoulder")
                        DataValues.Items.Add("Shirt")
                        DataValues.Items.Add("Chest")
                        DataValues.Items.Add("Waist")
                        DataValues.Items.Add("Legs")
                        DataValues.Items.Add("Feet")
                        DataValues.Items.Add("Wrists")
                        DataValues.Items.Add("Hands")
                        DataValues.Items.Add("Finger")
                        DataValues.Items.Add("Trinket")
                        DataValues.Items.Add("Shield")
                        DataValues.Items.Add("Back")
                        DataValues.Items.Add("Tabard")
                        DataValues.Items.Add("Holdable")
                        DataValues.Items.Add("Relic")
                    Case Is = "AllowableClass"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("All Classes")
                        DataValues.Items.Add("Melee Classes")
                        DataValues.Items.Add("Offensive Caster Classes")
                        DataValues.Items.Add("Healer Classes")
                        DataValues.Items.Add("Plate Classes")
                        DataValues.Items.Add("Mail Classes")
                        DataValues.Items.Add("Leather Classes")
                        DataValues.Items.Add("Cloth Classes")
                        DataValues.Items.Add("Warrior")
                        DataValues.Items.Add("Paladin")
                        DataValues.Items.Add("Hunter")
                        DataValues.Items.Add("Rogue")
                        DataValues.Items.Add("Priest")
                        DataValues.Items.Add("Death Knight")
                        DataValues.Items.Add("Shaman")
                        DataValues.Items.Add("Mage")
                        DataValues.Items.Add("Warlock")
                        DataValues.Items.Add("Druid")
                    Case Is = "AllowableRace"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("All Races")
                        DataValues.Items.Add("Alliance Races")
                        DataValues.Items.Add("Horde Races")
                        DataValues.Items.Add("Burning Crusade Races")
                        DataValues.Items.Add("Cataclysm Races")
                        DataValues.Items.Add("Human")
                        DataValues.Items.Add("Orc")
                        DataValues.Items.Add("Dwarf")
                        DataValues.Items.Add("Night Elf")
                        DataValues.Items.Add("Undead")
                        DataValues.Items.Add("Tauren")
                        DataValues.Items.Add("Gnome")
                        DataValues.Items.Add("Troll")
                        DataValues.Items.Add("Goblin")
                        DataValues.Items.Add("Blood Elf")
                        DataValues.Items.Add("Draenei")
                    Case Is = "Stat_Type1"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type2"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type3"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type4"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type5"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type6"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type7"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type8"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type9"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Stat_Type10"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Mana")
                        DataValues.Items.Add("Health")
                        DataValues.Items.Add("Agility")
                        DataValues.Items.Add("Strength")
                        DataValues.Items.Add("Intellect")
                        DataValues.Items.Add("Spirit")
                        DataValues.Items.Add("Stamina")
                        DataValues.Items.Add("Defense Rating")
                        DataValues.Items.Add("Dodge Rating")
                        DataValues.Items.Add("Parry Rating")
                        DataValues.Items.Add("Block Rating")
                        DataValues.Items.Add("Melee Hit Rating")
                        DataValues.Items.Add("Ranged Hit Rating")
                        DataValues.Items.Add("Spell Hit Rating")
                        DataValues.Items.Add("Melee Crit Rating")
                        DataValues.Items.Add("Ranged Crit Rating")
                        DataValues.Items.Add("Spell Crit Rating")
                        DataValues.Items.Add("Melee Haste Rating")
                        DataValues.Items.Add("Ranged Haste Rating")
                        DataValues.Items.Add("Spell Haste Rating")
                        DataValues.Items.Add("Resilience Rating")
                        DataValues.Items.Add("Haste Rating")
                        DataValues.Items.Add("Expertise Rating")
                        DataValues.Items.Add("Attack Power")
                        DataValues.Items.Add("Ranged Attack Power")
                        DataValues.Items.Add("Healing Done")
                        DataValues.Items.Add("Spell Damage Done")
                        DataValues.Items.Add("Mana Regen")
                        DataValues.Items.Add("Armor Penetration")
                        DataValues.Items.Add("Spell Power")
                        DataValues.Items.Add("Health Regen")
                        DataValues.Items.Add("Spell Penetration")
                        DataValues.Items.Add("Block Value")
                        DataValues.Items.Add("Mastery Rating")
                    Case Is = "Bonding"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("No Bounds")
                        DataValues.Items.Add("Binds on Pickup")
                        DataValues.Items.Add("Binds on Equip")
                    Case Is = "Material"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Undefined")
                        DataValues.Items.Add("Jewelry")
                        DataValues.Items.Add("Mail")
                        DataValues.Items.Add("Plate")
                        DataValues.Items.Add("Cloth")
                        DataValues.Items.Add("Leather")
                    Case Is = "SocketColor_1"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Meta")
                        DataValues.Items.Add("Red")
                        DataValues.Items.Add("Yellow")
                        DataValues.Items.Add("Blue")
                    Case Is = "SocketColor_2"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Meta")
                        DataValues.Items.Add("Red")
                        DataValues.Items.Add("Yellow")
                        DataValues.Items.Add("Blue")
                    Case Is = "SocketColor_3"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Meta")
                        DataValues.Items.Add("Red")
                        DataValues.Items.Add("Yellow")
                        DataValues.Items.Add("Blue")
                    Case Is = "SocketBonus"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("+8 Strength")
                        DataValues.Items.Add("+8 Agility")
                        DataValues.Items.Add("+12 Stamina")
                        DataValues.Items.Add("+8 Intellect")
                        DataValues.Items.Add("+9 Healing")
                        DataValues.Items.Add("+9 Spell Power")
                        DataValues.Items.Add("+16 Attack Power")
                End Select
            Case Is = "Bag"
                Select Case DataSet.Text
                    Case Is = "Class"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Container")
                    Case Is = "SubClass"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Bag")
                        DataValues.Items.Add("Soul Bag")
                        DataValues.Items.Add("Herb Bag")
                        DataValues.Items.Add("Enchanting Bag")
                        DataValues.Items.Add("Engineering Bag")
                        DataValues.Items.Add("Gem Bag")
                        DataValues.Items.Add("Mining Bag")
                        DataValues.Items.Add("Leatherworking Bag")
                        DataValues.Items.Add("Inscription Bag")
                    Case Is = "Quality"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Poor")
                        DataValues.Items.Add("Common")
                        DataValues.Items.Add("Uncommon")
                        DataValues.Items.Add("Rare")
                        DataValues.Items.Add("Epic")
                        DataValues.Items.Add("Legendary")
                        DataValues.Items.Add("Artifact")
                        DataValues.Items.Add("Bind to Account")
                    Case Is = "Flags"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("None (Default)")
                        DataValues.Items.Add("Soulbound")
                    Case Is = "FlagsExtra"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Both Factions (Default)")
                        DataValues.Items.Add("Horde")
                        DataValues.Items.Add("Alliance")
                        DataValues.Items.Add("Uses ExtendedCost")
                        DataValues.Items.Add("Disable Need Roll")
                    Case Is = "InventoryType"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("Bag")
                    Case Is = "AllowableClass"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("All Classes")
                        DataValues.Items.Add("Melee Classes")
                        DataValues.Items.Add("Offensive Caster Classes")
                        DataValues.Items.Add("Healer Classes")
                        DataValues.Items.Add("Plate Classes")
                        DataValues.Items.Add("Mail Classes")
                        DataValues.Items.Add("Leather Classes")
                        DataValues.Items.Add("Cloth Classes")
                        DataValues.Items.Add("Warrior")
                        DataValues.Items.Add("Paladin")
                        DataValues.Items.Add("Hunter")
                        DataValues.Items.Add("Rogue")
                        DataValues.Items.Add("Priest")
                        DataValues.Items.Add("Death Knight")
                        DataValues.Items.Add("Shaman")
                        DataValues.Items.Add("Mage")
                        DataValues.Items.Add("Warlock")
                        DataValues.Items.Add("Druid")
                    Case Is = "AllowableRace"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("All Races")
                        DataValues.Items.Add("Alliance Races")
                        DataValues.Items.Add("Horde Races")
                        DataValues.Items.Add("Burning Crusade Races")
                        DataValues.Items.Add("Cataclysm Races")
                        DataValues.Items.Add("Human")
                        DataValues.Items.Add("Orc")
                        DataValues.Items.Add("Dwarf")
                        DataValues.Items.Add("Night Elf")
                        DataValues.Items.Add("Undead")
                        DataValues.Items.Add("Tauren")
                        DataValues.Items.Add("Gnome")
                        DataValues.Items.Add("Troll")
                        DataValues.Items.Add("Goblin")
                        DataValues.Items.Add("Blood Elf")
                        DataValues.Items.Add("Draenei")
                    Case Is = "Bonding"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("No Bounds")
                        DataValues.Items.Add("Binds on Pickup")
                        DataValues.Items.Add("Binds on Equip")
                    Case Is = "BagFamily"
                        DataValues.Items.Clear()
                        DataValues.Items.Add("None")
                        DataValues.Items.Add("Soul Shards")
                        DataValues.Items.Add("Leatherworking Supplies")
                        DataValues.Items.Add("Inscription Supplies")
                        DataValues.Items.Add("Herbs")
                        DataValues.Items.Add("Enchanting Supplies")
                        DataValues.Items.Add("Engineering Supplies")
                        DataValues.Items.Add("Gems")
                        DataValues.Items.Add("Mining Supplies")
                End Select
        End Select
    End Sub

    Private Sub DataAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataAdd.Click
        AddData()
    End Sub

    Private Sub AddData()
        Dim SelIndex As Integer = DataGridView1.CurrentRow.Index
        Dim selectedRowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If selectedRowCount <= 0 Then
            MsgBox("Please select a row in the database first.", MsgBoxStyle.ApplicationModal, "Error")
        Else
            Select Case DataSet.Text
                Case Is = "Class"
                    Select Case DataValues.Text
                        Case Is = "Container"
                            DataGridView1(1, SelIndex).Value = "1"
                        Case Is = "Weapon"
                            DataGridView1(1, SelIndex).Value = "2"
                        Case Is = "Armor"
                            DataGridView1(1, SelIndex).Value = "4"
                    End Select
                Case Is = "SubClass"
                    Select Case DataValues.Text
                        Case Is = "Bag"
                            DataGridView1(2, SelIndex).Value = "0"
                        Case Is = "Soul Bag"
                            DataGridView1(2, SelIndex).Value = "1"
                        Case Is = "Herb Bag"
                            DataGridView1(2, SelIndex).Value = "2"
                        Case Is = "Enchanting Bag"
                            DataGridView1(2, SelIndex).Value = "3"
                        Case Is = "Engineering Bag"
                            DataGridView1(2, SelIndex).Value = "4"
                        Case Is = "Gem Bag"
                            DataGridView1(2, SelIndex).Value = "5"
                        Case Is = "Mining Bag"
                            DataGridView1(2, SelIndex).Value = "6"
                        Case Is = "Leatherworking Bag"
                            DataGridView1(2, SelIndex).Value = "7"
                        Case Is = "Inscription Bag"
                            DataGridView1(2, SelIndex).Value = "8"
                        Case Is = "Axe (1H)"
                            DataGridView1(2, SelIndex).Value = "0"
                        Case Is = "Axe (2H)"
                            DataGridView1(2, SelIndex).Value = "1"
                        Case Is = "Bow"
                            DataGridView1(2, SelIndex).Value = "2"
                        Case Is = "Gun"
                            DataGridView1(2, SelIndex).Value = "3"
                        Case Is = "Mace (1H)"
                            DataGridView1(2, SelIndex).Value = "4"
                        Case Is = "Mace (2H)"
                            DataGridView1(2, SelIndex).Value = "5"
                        Case Is = "Polearm"
                            DataGridView1(2, SelIndex).Value = "6"
                        Case Is = "Sword (1H)"
                            DataGridView1(2, SelIndex).Value = "7"
                        Case Is = "Sword (2H)"
                            DataGridView1(2, SelIndex).Value = "8"
                        Case Is = "Staff"
                            DataGridView1(2, SelIndex).Value = "10"
                        Case Is = "Fist Weapon"
                            DataGridView1(2, SelIndex).Value = "13"
                        Case Is = "Dagger"
                            DataGridView1(2, SelIndex).Value = "15"
                        Case Is = "Thrown"
                            DataGridView1(2, SelIndex).Value = "16"
                        Case Is = "Spear"
                            DataGridView1(2, SelIndex).Value = "17"
                        Case Is = "Crossbow"
                            DataGridView1(2, SelIndex).Value = "18"
                        Case Is = "Wand"
                            DataGridView1(2, SelIndex).Value = "19"
                        Case Is = "Fishing Pole"
                            DataGridView1(2, SelIndex).Value = "20"
                        Case Is = "Cloth"
                            DataGridView1(2, SelIndex).Value = "1"
                        Case Is = "Leather"
                            DataGridView1(2, SelIndex).Value = "2"
                        Case Is = "Mail"
                            DataGridView1(2, SelIndex).Value = "3"
                        Case Is = "Plate"
                            DataGridView1(2, SelIndex).Value = "4"
                        Case Is = "Shield"
                            DataGridView1(2, SelIndex).Value = "6"
                        Case Is = "Libram"
                            DataGridView1(2, SelIndex).Value = "7"
                        Case Is = "Idol"
                            DataGridView1(2, SelIndex).Value = "8"
                        Case Is = "Totem"
                            DataGridView1(2, SelIndex).Value = "9"
                        Case Is = "Sigil"
                            DataGridView1(2, SelIndex).Value = "10"
                    End Select
                Case Is = "Quality"
                    Select Case DataValues.Text
                        Case Is = "Poor"
                            DataGridView1(6, SelIndex).Value = "0"
                        Case Is = "Common"
                            DataGridView1(6, SelIndex).Value = "1"
                        Case Is = "Uncommon"
                            DataGridView1(6, SelIndex).Value = "2"
                        Case Is = "Rare"
                            DataGridView1(6, SelIndex).Value = "3"
                        Case Is = "Epic"
                            DataGridView1(6, SelIndex).Value = "4"
                        Case Is = "Legendary"
                            DataGridView1(6, SelIndex).Value = "5"
                        Case Is = "Artifact"
                            DataGridView1(6, SelIndex).Value = "6"
                        Case Is = "Bind to Account"
                            DataGridView1(6, SelIndex).Value = "7"
                    End Select
                Case Is = "Flags"
                    Select Case DataValues.Text
                        Case Is = "None (Default)"
                            DataGridView1(7, SelIndex).Value = "0"
                        Case Is = "Soulbound"
                            DataGridView1(7, SelIndex).Value = "1"
                        Case Is = "Heroic"
                            DataGridView1(7, SelIndex).Value = "8"
                        Case Is = "Totem"
                            DataGridView1(7, SelIndex).Value = "32"
                        Case Is = "Party Looted"
                            DataGridView1(7, SelIndex).Value = "2048"
                        Case Is = "Refundable"
                            DataGridView1(7, SelIndex).Value = "4096"
                        Case Is = "PvP Reward"
                            DataGridView1(7, SelIndex).Value = "32768"
                        Case Is = "Unique-Equipped"
                            DataGridView1(7, SelIndex).Value = "524288"
                        Case Is = "Throwable"
                            DataGridView1(7, SelIndex).Value = "4194304"
                        Case Is = "Bind to Account"
                            DataGridView1(7, SelIndex).Value = "134221824"
                    End Select
                Case Is = "FlagsExtra"
                    Select Case DataValues.Text
                        Case Is = "Both Factions (Default)"
                            DataGridView1(8, SelIndex).Value = "0"
                        Case Is = "Horde"
                            DataGridView1(8, SelIndex).Value = "1"
                        Case Is = "Alliance"
                            DataGridView1(8, SelIndex).Value = "2"
                        Case Is = "Uses ExtendedCost"
                            DataGridView1(8, SelIndex).Value = "4"
                        Case Is = "Need Roll Disabled"
                            DataGridView1(8, SelIndex).Value = "256"
                    End Select
                Case Is = "InventoryType"
                    Select Case DataValues.Text
                        Case Is = "Head"
                            DataGridView1(12, SelIndex).Value = "1"
                        Case Is = "Neck"
                            DataGridView1(12, SelIndex).Value = "2"
                        Case Is = "Shoulder"
                            DataGridView1(12, SelIndex).Value = "3"
                        Case Is = "Shirt"
                            DataGridView1(12, SelIndex).Value = "4"
                        Case Is = "Chest"
                            DataGridView1(12, SelIndex).Value = "5"
                        Case Is = "Waist"
                            DataGridView1(12, SelIndex).Value = "6"
                        Case Is = "Legs"
                            DataGridView1(12, SelIndex).Value = "7"
                        Case Is = "Feet"
                            DataGridView1(12, SelIndex).Value = "8"
                        Case Is = "Wrists"
                            DataGridView1(12, SelIndex).Value = "9"
                        Case Is = "Hands"
                            DataGridView1(12, SelIndex).Value = "10"
                        Case Is = "Finger"
                            DataGridView1(12, SelIndex).Value = "11"
                        Case Is = "Trinket"
                            DataGridView1(12, SelIndex).Value = "12"
                        Case Is = "Weapon"
                            DataGridView1(12, SelIndex).Value = "13"
                        Case Is = "Shield"
                            DataGridView1(12, SelIndex).Value = "14"
                        Case Is = "Ranged"
                            DataGridView1(12, SelIndex).Value = "15"
                        Case Is = "Back"
                            DataGridView1(12, SelIndex).Value = "16"
                        Case Is = "Two-Hand"
                            DataGridView1(12, SelIndex).Value = "17"
                        Case Is = "Bag"
                            DataGridView1(12, SelIndex).Value = "18"
                        Case Is = "Tabard"
                            DataGridView1(12, SelIndex).Value = "19"
                        Case Is = "Main-Hand"
                            DataGridView1(12, SelIndex).Value = "21"
                        Case Is = "Off-Hand"
                            DataGridView1(12, SelIndex).Value = "22"
                        Case Is = "Holdable"
                            DataGridView1(12, SelIndex).Value = "23"
                        Case Is = "Thrown"
                            DataGridView1(12, SelIndex).Value = "25"
                        Case Is = "Ranged Right"
                            DataGridView1(12, SelIndex).Value = "26"
                        Case Is = "Relic"
                            DataGridView1(12, SelIndex).Value = "28"
                    End Select
                Case Is = "AllowableClass"
                    Select Case DataValues.Text
                        Case Is = "All Classes"
                            DataGridView1(13, SelIndex).Value = "-1"
                        Case Is = "Melee Classes"
                            DataGridView1(13, SelIndex).Value = "1131"
                        Case Is = "Offensive Caster Classes"
                            DataGridView1(13, SelIndex).Value = "1490"
                        Case Is = "Healer Classes"
                            DataGridView1(13, SelIndex).Value = "1106"
                        Case Is = "Plate Classes"
                            DataGridView1(13, SelIndex).Value = "35"
                        Case Is = "Mail Classes"
                            DataGridView1(13, SelIndex).Value = "68"
                        Case Is = "Leather Classes"
                            DataGridView1(13, SelIndex).Value = "1032"
                        Case Is = "Cloth Classes"
                            DataGridView1(13, SelIndex).Value = "400"
                        Case Is = "Warrior"
                            DataGridView1(13, SelIndex).Value = "1"
                        Case Is = "Paladin"
                            DataGridView1(13, SelIndex).Value = "2"
                        Case Is = "Hunter"
                            DataGridView1(13, SelIndex).Value = "4"
                        Case Is = "Rogue"
                            DataGridView1(13, SelIndex).Value = "8"
                        Case Is = "Priest"
                            DataGridView1(13, SelIndex).Value = "16"
                        Case Is = "Death Knight"
                            DataGridView1(13, SelIndex).Value = "32"
                        Case Is = "Shaman"
                            DataGridView1(13, SelIndex).Value = "64"
                        Case Is = "Mage"
                            DataGridView1(13, SelIndex).Value = "128"
                        Case Is = "Warlock"
                            DataGridView1(13, SelIndex).Value = "256"
                        Case Is = "Druid"
                            DataGridView1(13, SelIndex).Value = "1024"
                    End Select
                Case Is = "AllowableRace"
                    Select Case DataValues.Text
                        Case Is = "All Races"
                            DataGridView1(14, SelIndex).Value = "-1"
                        Case Is = "Alliance Races"
                            DataGridView1(14, SelIndex).Value = "1101"
                        Case Is = "Horde Races"
                            DataGridView1(14, SelIndex).Value = "946"
                        Case Is = "Burning Crusade Races"
                            DataGridView1(14, SelIndex).Value = "1536"
                        Case Is = "Cataclysm Classes"
                            DataGridView1(14, SelIndex).Value = "256"
                        Case Is = "Human"
                            DataGridView1(14, SelIndex).Value = "1"
                        Case Is = "Orc"
                            DataGridView1(14, SelIndex).Value = "2"
                        Case Is = "Dwarf"
                            DataGridView1(14, SelIndex).Value = "4"
                        Case Is = "Night Elf"
                            DataGridView1(14, SelIndex).Value = "8"
                        Case Is = "Undead"
                            DataGridView1(14, SelIndex).Value = "16"
                        Case Is = "Tauren"
                            DataGridView1(14, SelIndex).Value = "32"
                        Case Is = "Gnome"
                            DataGridView1(14, SelIndex).Value = "64"
                        Case Is = "Troll"
                            DataGridView1(14, SelIndex).Value = "128"
                        Case Is = "Goblin"
                            DataGridView1(14, SelIndex).Value = "256"
                        Case Is = "Blood Elf"
                            DataGridView1(14, SelIndex).Value = "512"
                        Case Is = "Draenei"
                            DataGridView1(14, SelIndex).Value = "1024"
                    End Select
                Case Is = "Stat_Type1"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(27, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(27, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(27, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(27, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(27, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(27, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(27, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(27, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(27, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(27, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(27, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(27, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(27, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(27, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(27, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(27, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(27, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(27, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(27, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(27, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(27, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(27, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(27, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(27, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(27, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(27, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(27, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(27, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(27, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(27, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(27, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(27, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(27, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(27, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(27, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(27, SelIndex).Value = "49"
                    End Select
                Case Is = "Stat_Type2"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(29, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(29, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(29, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(29, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(29, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(29, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(29, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(29, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(29, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(29, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(29, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(29, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(29, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(29, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(29, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(29, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(29, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(29, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(29, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(29, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(29, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(29, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(29, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(29, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(29, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(29, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(29, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(29, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(29, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(29, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(29, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(29, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(29, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(29, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(29, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(29, SelIndex).Value = "49"
                    End Select
                Case Is = "Stat_Type3"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(31, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(31, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(31, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(31, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(31, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(31, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(31, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(31, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(31, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(31, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(31, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(31, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(31, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(31, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(31, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(31, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(31, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(31, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(31, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(31, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(31, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(31, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(31, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(31, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(31, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(31, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(31, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(31, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(31, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(31, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(31, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(31, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(31, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(31, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(31, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(31, SelIndex).Value = "49"
                    End Select
                Case Is = "Stat_Type4"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(33, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(33, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(33, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(33, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(33, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(33, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(33, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(33, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(33, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(33, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(33, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(33, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(33, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(33, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(33, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(33, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(33, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(33, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(33, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(33, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(33, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(33, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(33, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(33, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(33, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(33, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(33, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(33, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(33, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(33, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(33, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(33, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(33, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(33, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(33, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(33, SelIndex).Value = "49"
                    End Select
                Case Is = "Stat_Type5"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(35, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(35, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(35, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(35, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(35, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(35, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(35, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(35, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(35, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(35, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(35, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(35, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(35, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(35, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(35, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(35, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(35, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(35, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(35, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(35, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(35, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(35, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(35, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(35, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(35, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(35, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(35, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(35, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(35, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(35, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(35, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(35, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(35, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(35, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(35, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(35, SelIndex).Value = "49"
                    End Select
                Case Is = "Stat_Type6"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(37, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(37, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(37, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(37, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(37, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(37, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(37, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(37, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(37, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(37, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(37, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(37, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(37, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(37, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(37, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(37, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(37, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(37, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(37, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(37, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(37, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(37, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(37, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(37, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(37, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(37, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(37, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(37, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(37, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(37, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(37, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(37, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(37, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(37, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(37, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(37, SelIndex).Value = "49"
                    End Select
                Case Is = "Stat_Type7"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(39, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(39, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(39, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(39, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(39, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(39, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(39, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(39, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(39, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(39, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(39, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(39, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(39, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(39, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(39, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(39, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(39, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(39, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(39, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(39, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(39, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(39, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(39, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(39, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(39, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(39, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(39, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(39, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(39, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(39, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(39, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(39, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(39, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(39, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(39, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(39, SelIndex).Value = "49"
                    End Select
                Case Is = "Stat_Type8"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(41, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(41, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(41, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(41, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(41, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(41, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(41, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(41, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(41, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(41, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(41, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(41, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(41, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(41, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(41, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(41, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(41, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(41, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(41, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(41, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(41, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(41, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(41, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(41, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(41, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(41, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(41, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(41, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(41, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(41, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(41, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(41, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(41, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(41, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(41, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(41, SelIndex).Value = "49"
                    End Select
                Case Is = "Stat_Type9"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(43, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(43, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(43, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(43, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(43, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(43, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(43, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(43, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(43, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(43, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(43, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(43, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(43, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(43, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(43, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(43, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(43, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(43, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(43, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(43, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(43, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(43, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(43, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(43, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(43, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(43, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(43, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(43, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(43, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(43, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(43, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(43, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(43, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(43, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(43, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(43, SelIndex).Value = "49"
                    End Select
                Case Is = "Stat_Type10"
                    Select Case DataValues.Text
                        Case Is = "Mana"
                            DataGridView1(45, SelIndex).Value = "0"
                        Case Is = "Health"
                            DataGridView1(45, SelIndex).Value = "1"
                        Case Is = "Agility"
                            DataGridView1(45, SelIndex).Value = "3"
                        Case Is = "Strength"
                            DataGridView1(45, SelIndex).Value = "4"
                        Case Is = "Intellect"
                            DataGridView1(45, SelIndex).Value = "5"
                        Case Is = "Spirit"
                            DataGridView1(45, SelIndex).Value = "6"
                        Case Is = "Stamina"
                            DataGridView1(45, SelIndex).Value = "7"
                        Case Is = "Defense Rating"
                            DataGridView1(45, SelIndex).Value = "12"
                        Case Is = "Dodge Rating"
                            DataGridView1(45, SelIndex).Value = "13"
                        Case Is = "Parry Rating"
                            DataGridView1(45, SelIndex).Value = "14"
                        Case Is = "Block Rating"
                            DataGridView1(45, SelIndex).Value = "15"
                        Case Is = "Melee Hit Rating"
                            DataGridView1(45, SelIndex).Value = "16"
                        Case Is = "Ranged Hit Rating"
                            DataGridView1(45, SelIndex).Value = "17"
                        Case Is = "Spell Hit Rating"
                            DataGridView1(45, SelIndex).Value = "18"
                        Case Is = "Melee Crit Rating"
                            DataGridView1(45, SelIndex).Value = "19"
                        Case Is = "Ranged Crit Rating"
                            DataGridView1(45, SelIndex).Value = "20"
                        Case Is = "Spell Crit Rating"
                            DataGridView1(45, SelIndex).Value = "21"
                        Case Is = "Melee Haste Rating"
                            DataGridView1(45, SelIndex).Value = "28"
                        Case Is = "Ranged Haste Rating"
                            DataGridView1(45, SelIndex).Value = "29"
                        Case Is = "Spell Haste Rating"
                            DataGridView1(45, SelIndex).Value = "30"
                        Case Is = "Hit Rating"
                            DataGridView1(45, SelIndex).Value = "31"
                        Case Is = "Crit Rating"
                            DataGridView1(45, SelIndex).Value = "32"
                        Case Is = "Resilience"
                            DataGridView1(45, SelIndex).Value = "35"
                        Case Is = "Haste Rating"
                            DataGridView1(45, SelIndex).Value = "36"
                        Case Is = "Expertise"
                            DataGridView1(45, SelIndex).Value = "37"
                        Case Is = "Attack Power"
                            DataGridView1(45, SelIndex).Value = "38"
                        Case Is = "Ranged Attack Power"
                            DataGridView1(45, SelIndex).Value = "39"
                        Case Is = "Healing Done"
                            DataGridView1(45, SelIndex).Value = "41"
                        Case Is = "Spell Damage Done"
                            DataGridView1(45, SelIndex).Value = "42"
                        Case Is = "Mana Regen"
                            DataGridView1(45, SelIndex).Value = "43"
                        Case Is = "Armor Penetration"
                            DataGridView1(45, SelIndex).Value = "44"
                        Case Is = "Spell Power"
                            DataGridView1(45, SelIndex).Value = "45"
                        Case Is = "Health Regen"
                            DataGridView1(45, SelIndex).Value = "46"
                        Case Is = "Spell Penetration"
                            DataGridView1(45, SelIndex).Value = "47"
                        Case Is = "Block Value"
                            DataGridView1(45, SelIndex).Value = "48"
                        Case Is = "Mastery Rating"
                            DataGridView1(45, SelIndex).Value = "49"
                    End Select
                Case Is = "DamageType"
                    Select Case DataValues.Text
                        Case Is = "Physical"
                            DataGridView1(49, SelIndex).Value = "0"
                        Case Is = "Holy"
                            DataGridView1(49, SelIndex).Value = "1"
                        Case Is = "Fire"
                            DataGridView1(49, SelIndex).Value = "2"
                        Case Is = "Nature"
                            DataGridView1(49, SelIndex).Value = "3"
                        Case Is = "Frost"
                            DataGridView1(49, SelIndex).Value = "4"
                        Case Is = "Shadow"
                            DataGridView1(49, SelIndex).Value = "5"
                        Case Is = "Arcane"
                            DataGridView1(49, SelIndex).Value = "6"
                    End Select
                Case Is = "Bonding"
                    Select Case DataValues.Text
                        Case Is = "No Bounds"
                            DataGridView1(87, SelIndex).Value = "0"
                        Case Is = "Binds on Pickup"
                            DataGridView1(87, SelIndex).Value = "1"
                        Case Is = "Binds on Equip"
                            DataGridView1(87, SelIndex).Value = "2"
                    End Select
                Case Is = "Material"
                    Select Case DataValues.Text
                        Case Is = "Undefined"
                            DataGridView1(94, SelIndex).Value = "0"
                        Case Is = "Metal"
                            DataGridView1(94, SelIndex).Value = "1"
                        Case Is = "Wood"
                            DataGridView1(94, SelIndex).Value = "2"
                        Case Is = "Jewelry"
                            DataGridView1(94, SelIndex).Value = "4"
                        Case Is = "Mail"
                            DataGridView1(94, SelIndex).Value = "5"
                        Case Is = "Plate"
                            DataGridView1(94, SelIndex).Value = "6"
                        Case Is = "Cloth"
                            DataGridView1(94, SelIndex).Value = "7"
                        Case Is = "Leather"
                            DataGridView1(94, SelIndex).Value = "8"
                    End Select
                Case Is = "Sheath"
                    Select Case DataValues.Text
                        Case Is = "Two-Handed"
                            DataGridView1(95, SelIndex).Value = "1"
                        Case Is = "Staff"
                            DataGridView1(95, SelIndex).Value = "2"
                        Case Is = "One-Handed"
                            DataGridView1(95, SelIndex).Value = "3"
                        Case Is = "Shield"
                            DataGridView1(95, SelIndex).Value = "4"
                        Case Is = "Off-Hand"
                            DataGridView1(95, SelIndex).Value = "6"
                    End Select
                Case Is = "BagFamily"
                    Select Case DataValues.Text
                        Case Is = "None"
                            DataGridView1(103, SelIndex).Value = "0"
                        Case Is = "Soul Shards"
                            DataGridView1(103, SelIndex).Value = "4"
                        Case Is = "Leatherworking Supplies"
                            DataGridView1(103, SelIndex).Value = "8"
                        Case Is = "Inscription Supplies"
                            DataGridView1(103, SelIndex).Value = "16"
                        Case Is = "Herbs"
                            DataGridView1(103, SelIndex).Value = "32"
                        Case Is = "Enchanting Supplies"
                            DataGridView1(103, SelIndex).Value = "64"
                        Case Is = "Engineering Supplies"
                            DataGridView1(103, SelIndex).Value = "128"
                        Case Is = "Gems"
                            DataGridView1(103, SelIndex).Value = "512"
                        Case Is = "Mining Supplies"
                            DataGridView1(103, SelIndex).Value = "1024"
                    End Select
                Case Is = "SocketColor_1"
                    Select Case DataValues.Text
                        Case Is = "Meta"
                            DataGridView1(105, SelIndex).Value = "1"
                        Case Is = "Red"
                            DataGridView1(105, SelIndex).Value = "2"
                        Case Is = "Yellow"
                            DataGridView1(105, SelIndex).Value = "4"
                        Case Is = "Blue"
                            DataGridView1(105, SelIndex).Value = "8"
                    End Select
                Case Is = "SocketColor_2"
                    Select Case DataValues.Text
                        Case Is = "Meta"
                            DataGridView1(107, SelIndex).Value = "1"
                        Case Is = "Red"
                            DataGridView1(107, SelIndex).Value = "2"
                        Case Is = "Yellow"
                            DataGridView1(107, SelIndex).Value = "4"
                        Case Is = "Blue"
                            DataGridView1(107, SelIndex).Value = "8"
                    End Select
                Case Is = "SocketColor_3"
                    Select Case DataValues.Text
                        Case Is = "Meta"
                            DataGridView1(109, SelIndex).Value = "1"
                        Case Is = "Red"
                            DataGridView1(109, SelIndex).Value = "2"
                        Case Is = "Yellow"
                            DataGridView1(109, SelIndex).Value = "4"
                        Case Is = "Blue"
                            DataGridView1(109, SelIndex).Value = "8"
                    End Select
                Case Is = "SocketBonus"
                    Select Case DataValues.Text
                        Case Is = "+8 Strength"
                            DataGridView1(111, SelIndex).Value = "3312"
                        Case Is = "+8 Agility"
                            DataGridView1(111, SelIndex).Value = "3313"
                        Case Is = "+12 Stamina"
                            DataGridView1(111, SelIndex).Value = "3305"
                        Case Is = "+8 Intellect"
                            DataGridView1(111, SelIndex).Value = "3353"
                        Case Is = "+9 Healing"
                            DataGridView1(111, SelIndex).Value = "2872"
                        Case Is = "+9 Spell Power"
                            DataGridView1(111, SelIndex).Value = "3753"
                        Case Is = "+16 Attack Power"
                            DataGridView1(111, SelIndex).Value = "3877"
                    End Select
                    '94
            End Select
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim SelIndex As Integer = DataGridView1.CurrentRow.Index
            Dim selectedRowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
            If selectedRowCount <= 0 Then
                MsgBox("Please select a row in the database first.", MsgBoxStyle.ApplicationModal, "Error")
            Else
                StreamWriteSingle()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub StreamWriteSingle()
        Dim SelIndex As Integer = DataGridView1.CurrentRow.Index
        Dim TotalCols As Integer = DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)
        Dim CurrentCol As Integer = 0
        Dim DataInfo As String = "INSERT INTO item_template VALUES ('"

        Try
            Do
                DataInfo &= DataGridView1.Item(CurrentCol, SelIndex).Value & "', '"
                CurrentCol = CurrentCol + 1
            Loop Until CurrentCol = TotalCols - 1
            DataInfo &= DataGridView1.Item(CurrentCol, SelIndex).Value & "';"


            With FolderBrowserDialog1
                .RootFolder = Environment.SpecialFolder.Desktop
                .SelectedPath = "C:\"
                If .ShowDialog = DialogResult.OK Then
                    Try
                        Using sw As StreamWriter = New StreamWriter(.SelectedPath & "\" & "EasyItemMaker.sql")
                            sw.WriteLine("#--------------------------------------------------------------")
                            sw.WriteLine("# This script was written with Easy Item Maker v1.0 by willgtl")
                            sw.WriteLine("#--------------------------------------------------------------")
                            sw.WriteLine("")
                            sw.WriteLine(DataInfo)
                            sw.Close()
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub StreamWriteAll()
        Dim TotalRows As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Visible)
        Dim CurrentRow As Integer = 1
        Dim TotalCols As Integer = DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)
        Dim CurrentCol As Integer = 0
        Dim DataInfo As String = "INSERT INTO item_template VALUES ('"

        Try
            With FolderBrowserDialog1
                .RootFolder = Environment.SpecialFolder.Desktop
                .SelectedPath = "C:\"
                If .ShowDialog = DialogResult.OK Then
                    Try
                        Using sw As StreamWriter = New StreamWriter(.SelectedPath & "\" & "EasyItemMaker.sql")
                            sw.WriteLine("#--------------------------------------------------------------")
                            sw.WriteLine("# This script was written with Easy Item Maker v1.0 by willgtl")
                            sw.WriteLine("#--------------------------------------------------------------")
                            sw.WriteLine("")
                            Do
                                Do
                                    DataInfo &= DataGridView1.Item(CurrentCol, CurrentRow).Value & "', '"
                                    CurrentCol = CurrentCol + 1
                                Loop Until CurrentCol = TotalCols - 1
                                DataInfo &= DataGridView1.Item(CurrentCol, CurrentRow).Value & "';"
                                sw.WriteLine(DataInfo)
                                DataInfo = "INSERT INTO item_template VALUES ('"
                                CurrentRow = CurrentRow + 1
                            Loop Until CurrentRow = TotalRows - 1
                            sw.Close()
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message & " " & CurrentRow & "(" & TotalRows & ")" & ", " & CurrentCol & "(" & TotalCols & ")")
                        MsgBox(DataInfo)
                    End Try
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Feature currently unavailable")
    End Sub
End Class
